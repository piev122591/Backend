using Maestro.Core.Interfaces.IAssetRepo.IAssetTypeStatusRepo;
using Maestro.Domain.Admin.Asset;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Maestro.Infrastructure.Persistence.AssetRepo.AssetQueries
{
    public class AssetTypeStatusQueryRepository : IAssetTypeStatusQueryRepository
    {
        public Task<List<AssetTypeStatus>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<AssetTypeStatus> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
