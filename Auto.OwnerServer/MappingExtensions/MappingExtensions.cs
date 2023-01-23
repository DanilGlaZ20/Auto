using Auto.Data.Entities;
using Auto.OwnerServer;
using Auto.OwnersServer;

namespace Auto.OwnerServer.MappingExtensions;

public static class MappingExtensions
{
    public static OwnerByRegNumberResult? ToOwnerByRegNumberResult(this Owner? owner)
    {
        if (owner != null)
        {
            return new OwnerByRegNumberResult
            {
                Fullname = owner.FirstName + owner.LastName + owner.MiddleName,
                Driverlicence = owner.GetDriverLicence.Replace("&", " "),
                RegCodeVehicle = owner.Vehicle?.Registration
            };
        }

        return null;
    }
}