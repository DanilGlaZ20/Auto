using System.Collections;
using System.Collections.Generic;
using Auto.Data.Entities;
using Newtonsoft.Json;

namespace Auto.Data.Entities
{
    public partial class Owner
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int Experience { get; set; }
        public string Serial { get; set; }
        public string Number { get; set; }

        [Newtonsoft.Json.JsonIgnore] public Vehicle? Vehicle { get; set; }

        [Newtonsoft.Json.JsonIgnore] public string GetDriverLicence => $"{Serial}&{Number}";
    }
}