using Auto.Data;
using Auto.Data.Entities;
using Auto.OwnerServer.Interfaces;

namespace Auto.OwnerServer.Services;

public class OwnersRepositoryService : IOwnersRepositoryService
{
    private readonly IAutoDatabase _context;

    public OwnersRepositoryService(IAutoDatabase context)
    {
        _context = context;
    }
    public Owner? GetOwnerByRegNumber(string regNumber)
    {
        return _context.ListOwners().SingleOrDefault(o => o.Vehicle != null && o.Vehicle.Registration.Equals(regNumber));
    }
}