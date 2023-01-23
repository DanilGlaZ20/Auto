using Auto.Messages;

namespace Auto.Messages
{
    public class NewOwnerPhoneMessage : NewOwnerMessage
    {
        public string PhoneNumber { get; set; }

        public NewOwnerPhoneMessage(NewOwnerMessage owner, string phoneNumber)
        {
            this.FirstName = owner.FirstName;
            this.MiddleName = owner.MiddleName;
            this.LastName = owner.LastName;
            this.Age = owner.Age;
            this.Experience = owner.Experience;
            this.Serial = owner.Serial;
            this.Number = owner.Number;
            this.RegCodeVehicle = owner.RegCodeVehicle;
            this.CreatedAt = owner.CreatedAt;
            PhoneNumber = phoneNumber;
        }
    }
}