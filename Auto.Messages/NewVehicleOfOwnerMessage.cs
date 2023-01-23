using System;

namespace Auto.Messages
{
    public class NewVehicleOfOwnerMessage
    {
        public NewVehicleOfOwnerMessage(string serial, string number, string? newVehicle, string? oldVehicle)
        {
            Serial = serial;
            Number = number;
            NewVehicle = newVehicle;
            OldVehicle = oldVehicle;
            CreatedAt = DateTimeOffset.Now;
        }

        public string Serial { get; set; }
        public string Number { get; set; }
        public string? NewVehicle { get; set; }
        public string? OldVehicle { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
    }
}