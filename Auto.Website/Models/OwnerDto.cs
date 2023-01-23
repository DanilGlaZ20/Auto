using System;

namespace Auto.Website.Models
{

    public class OwnerDto
    {
        public OwnerDto()
        {
        }

        public OwnerDto(string firstName, string lastName, string middleName, string age, string experience,
            string serial, string number, string vehicleNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
            Age = Convert.ToInt32(age);
            Experience = Convert.ToInt32(experience);
            Serial = serial;
            Number = number;
            VehicleNumber = vehicleNumber;
        }

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int Experience { get; set; }
        public string Serial { get; set; }
        public string Number { get; set; }

        public string? VehicleNumber { get; set; }

        [Newtonsoft.Json.JsonIgnore] public string GetDriverLicence => $"{Serial}&{Number}";
    }
}