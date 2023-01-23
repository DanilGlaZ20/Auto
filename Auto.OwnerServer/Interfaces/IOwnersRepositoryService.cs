using Auto.Data.Entities;

namespace Auto.OwnerServer.Interfaces;

public interface IOwnersRepositoryService
{
    public Owner? GetOwnerByRegNumber(string regNumber);
}