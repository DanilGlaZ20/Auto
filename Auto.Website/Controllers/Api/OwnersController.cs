using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using Auto.Data;
using Auto.Data.Entities;
using Auto.Website.Models;
using EasyNetQ;
using Auto.Messages;
using Microsoft.AspNetCore.Mvc;

namespace Auto.Website.Controllers.Api
{

    [Route("api/[controller]")]
    [ApiController]
    public class OwnersController : ControllerBase
    {
        private readonly IAutoDatabase _context;
        private readonly IBus _bus;

        public OwnersController(IAutoDatabase context, IBus bus)
        {
            _context = context;
            _bus = bus;
        }

        [HttpPost]
        [Produces("application/hal+json")]
        public async Task<IActionResult> Get(int index = 0, int count = 10)
        {
            dynamic result;
            try
            {
                var items = _context.ListOwners().Skip(index).Take(count).Select(GetResource);
                var total = _context.CountOwners();
                var links = Paginate("/api/owners", index, count, total);

                result = new
                {
                    links, index, count, total, items
                };
                return Ok(result);
            }
            catch (Exception e)
            {
                result = new {message = e.Message};
            }

            return BadRequest(result);
        }

        [HttpPost]
        [Produces("application/hal+json")]
        [Route("{driverLicence}")]
        public async Task<IActionResult> GetByName(string driverLicence)
        {
            dynamic result;
            try
            {
                var item = GetResource(_context.FindOwnerByDriverLicence(driverLicence), driverLicence);
                if (item == null)
                {
                    throw new Exception("Владелец с таким водительским удостоверением не найден");
                }

                var total = _context.CountOwners();
                result = new
                {
                    total,
                    item
                };
                PublishNewOwnerMessage(_context.FindOwnerByDriverLicence(driverLicence));
                return Ok(result);
            }
            catch (Exception e)
            {
                result = new {message = e.Message};
            }

            return BadRequest(result);
        }

        [HttpPost]
        [Produces("application/hal+json")]
        [Route("add")]
        public async Task<IActionResult> Add([FromBody] OwnerDto ownerDto)
        {
            dynamic result;
            try
            {
                Vehicle vehicle = null;
                if (!string.IsNullOrEmpty(ownerDto.VehicleNumber))
                {
                    vehicle = _context.FindVehicle(ownerDto.VehicleNumber);
                }

                var ownerInContext = _context.FindOwnerByDriverLicence(ownerDto.GetDriverLicence);
                if (ownerInContext == null)
                {
                    Owner newOwner = CreateOwner(ownerDto, vehicle);
                    result = new
                    {
                        message = "Создан новый владелец",
                        owner = GetResource(newOwner)
                    };
                    PublishNewOwnerMessage(newOwner);
                    return Ok(result);
                }

                result = new {message = "Владелец с таким именем уже существует", owner = GetResource(ownerInContext)};
            }
            catch (Exception e)
            {
                result = new {message = e.Message};
            }

            return BadRequest(result);
        }

        [HttpPost]
        [Produces("application/hal+json")]
        [Route("delete/{name}")]
        public async Task<IActionResult> Remove(string name)
        {
            var owner = _context.FindOwnerByDriverLicence(name);
            _context.DeleteOwner(owner);
            return Ok(owner);
        }

        [HttpPost]
        [Produces("application/hal+json")]
        [Route("update/{name}")]
        public async Task<IActionResult> Update(string name, [FromBody] OwnerDto owner)
        {
            dynamic result;
            try
            {
                Vehicle vehicle = null;
                if (!string.IsNullOrEmpty(owner.VehicleNumber))
                {
                    vehicle = _context.FindVehicle(owner.VehicleNumber);
                }

                var ownerInContext =
                    _context.FindOwnerByDriverLicence(name);
                if (ownerInContext == null)
                {
                    result = new
                    {
                        message = "Владелец с такими водительскими правами не обнаружен.",
                    };
                    return BadRequest(result);
                }

                var oldName = ownerInContext.GetDriverLicence;

                ownerInContext.FirstName = owner.FirstName;
                ownerInContext.MiddleName = owner.MiddleName;
                ownerInContext.LastName = owner.LastName;
                ownerInContext.Age = owner.Age;
                ownerInContext.Experience = owner.Experience;
                ownerInContext.Serial = owner.Serial;
                ownerInContext.Number = owner.Number;
                ownerInContext.Vehicle = vehicle;

                if (ownerInContext.Vehicle != vehicle)
                {
                    PublishNewVehicleOfOwnerMessage(ownerInContext.Serial, ownerInContext.Number,
                        vehicle?.Registration, ownerInContext.Vehicle?.Registration);
                }

                _context.UpdateOwner(ownerInContext, oldName);

                return await GetByName(ownerInContext.GetDriverLicence);
            }
            catch (Exception e)
            {
                result = new {message = e.Message};
            }

            return BadRequest(result);
        }



        private Vehicle ParseVehicle(dynamic href)
        {
            var token = ((string) href).Split("/").LastOrDefault();
            return token != default ? _context.FindVehicle(token) : null;
        }

        private Owner CreateOwner(OwnerDto owner, Vehicle vehicle)
        {
            Owner newOwner = new Owner
            {
                FirstName = owner.FirstName,
                MiddleName = owner.MiddleName,
                LastName = owner.LastName,
                Age = owner.Age,
                Experience = owner.Experience,
                Serial = owner.Serial,
                Number = owner.Number,
            };

            newOwner.Vehicle = vehicle;

            _context.CreateOwner(newOwner);
            return newOwner;
        }

        private dynamic GetResource(Owner owner)
        {
            return GetResource(owner, null);
        }

        private dynamic GetResource(Owner owner, string name = null)
        {
            if (name != null && owner.GetDriverLicence != name)
            {
                return null;
            }

            var pathOwner = "/api/owners/";
            var pathVehicle = "/api/vehicles/";
            var ownerDynamic = owner.ToDynamic();

            dynamic links = new ExpandoObject();
            links.self = new
            {
                href = $"{pathOwner}{owner.GetDriverLicence}"
            };
            if (owner.Vehicle != null)
                links.vehicle = new
                {
                    href = $"{pathVehicle}{owner.Vehicle.Registration}"
                };

            ownerDynamic._links = links;
            ownerDynamic.actions = new
            {
                update = new
                {
                    href = $"/api/owners/update",
                    accept = "application/json"
                },
                delete = new
                {
                    href = $"/api/owners/delete/{owner.GetDriverLicence}"
                }
            };
            return ownerDynamic;
        }

        private dynamic Paginate(string url, int index, int count, int total)
        {
            dynamic links = new ExpandoObject();
            links.self = new {href = url};
            links.final = new {href = $"{url}?index={total - (total % count)}&count={count}"};
            links.first = new {href = $"{url}?index=0&count={count}"};
            if (index > 0) links.previous = new {href = $"{url}?index={index - count}&count={count}"};
            if (index + count < total) links.next = new {href = $"{url}?index={index + count}&count={count}"};
            return links;
        }

        private void PublishNewOwnerMessage(Owner owner)
        {
            var message = new NewOwnerMessage(owner.FirstName, owner.MiddleName, owner.LastName, owner.Age,
                owner.Experience, owner.Serial, owner.Number, owner.Vehicle.Registration);
            _bus.PubSub.Publish(message);
        }

        private void PublishNewVehicleOfOwnerMessage(string serial, string number, string newVehicle, string oldVehicle)
        {
            var message = new NewVehicleOfOwnerMessage(serial, number, newVehicle, oldVehicle);
            _bus.PubSub.Publish(message);
        }
    }
}