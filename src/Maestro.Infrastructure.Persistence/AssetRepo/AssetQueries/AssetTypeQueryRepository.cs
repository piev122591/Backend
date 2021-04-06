using Maestro.Core.Interfaces.IAssetRepo.IAssetTypeRepo;
using Maestro.Domain.Admin.Asset;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Maestro.Infrastructure.Persistence.AssetRepo.AssetQueries
{
    public class AssetTypeQueryRepository : IAssetTypeQueryRepository
    {
        public Task<List<AssetType>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<AssetType> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
