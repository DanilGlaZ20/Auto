using System.Threading.Tasks;
using Grpc.Core;
using Auto.Data;
using Auto.InfoOwnerServer;
using Microsoft.Extensions.Logging;

namespace Auto.InfoOwnerServer.Services
{

    public class OwnerInfoService : OwnerInfo.OwnerInfoBase
    {
        private readonly ILogger<OwnerInfoService> _logger;
        private readonly IAutoDatabase _db;

        public OwnerInfoService(ILogger<OwnerInfoService> logger, IAutoDatabase db)
        {
            _logger = logger;
            _db = db;
        }

        public override Task<OwnerInfoReply> GetOwnerInfo(OwnerInfoRequest request, ServerCallContext context)
        {
            var owner = _db.FindOwnerByDriverLicence(request.RegisterNumber);
            return Task.FromResult(new OwnerInfoReply()
            {
                Fullname = owner.MiddleName + " " + owner.FirstName + " " + owner.LastName,
                DriverLicence = owner.GetDriverLicence,
                RegCodeVehicle = owner.Vehicle?.Registration
            });
        }
    }
}