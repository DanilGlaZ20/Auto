using System;

namespace Auto.Messages
{

    public class NewOwnerMessage
    {
        public NewOwnerMessage()
        {

        }

        public NewOwnerMessage(string firstName, string middleName, string lastName,
            int age, int experience, string serial, string number, string? regCodeVehicle = null)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            Age = age;
            Experience = experience;
            Serial = serial;
            Number = number;
            RegCodeVehicle = regCodeVehicle;
            CreatedAt = DateTimeOffset.Now;
        }

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public int Age { get; set; }

        public int Experience { get; set; }

        public string Serial { get; set; }

        public string Number { get; set; }

        public string? RegCodeVehicle { get; set; }

        public DateTimeOffset CreatedAt { get; set; }

    }
}