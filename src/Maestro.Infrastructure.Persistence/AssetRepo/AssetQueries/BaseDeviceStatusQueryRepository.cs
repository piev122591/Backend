using Maestro.Core.Interfaces.IAssetRepo.IBaseDeviceStatusRepo;
using Maestro.Domain.Admin.Asset;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Maestro.Infrastructure.Persistence.AssetRepo.AssetQueries
{
    public class BaseDeviceStatusQueryRepository : IBaseDeviceStatusQueryRepository
    {
        public Task<List<BaseDeviceStatus>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<BaseDeviceStatus> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
