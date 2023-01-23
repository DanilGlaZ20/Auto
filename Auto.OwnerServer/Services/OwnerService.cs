using Auto.OwnerServer
using Grpc.Core;

namespace Auto.OwnerServer.Services;

public class OwnerServer : OwnerServer.OwnerService.OwnerServiceBase
{
    private readonly IOwnersRepositoryService _service;

    public OwnerService(IOwnersRepositoryService service)
    {
        _service = service;
    }

    public override Task<OwnerByRegNumberResult?> GetOwnerByRegNumber(OwnerByRegNumberRequest request,
        ServerCallContext context)
    {
        return Task.FromResult(_service.GetOwnerByRegNumber(request.RegisterNumber).ToOwnerByRegNumberResult());
    }
}