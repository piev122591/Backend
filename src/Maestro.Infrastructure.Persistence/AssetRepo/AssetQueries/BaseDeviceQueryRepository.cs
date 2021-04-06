using Maestro.Core.Interfaces.IAssetRepo.IBaseDeviceRepo;
using Maestro.Domain.Admin.Asset;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Maestro.Infrastructure.Persistence.AssetRepo.AssetQueries
{
    public class BaseDeviceQueryRepository : IBaseDeviceQueryRepository
    {
        public Task<List<BaseDevice>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<BaseDevice> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
