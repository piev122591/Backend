using Maestro.Core.Interfaces.IWirelessRepo.IPlansRepo;
using Maestro.Domain.Entities.Wireless;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Maestro.Infrastructure.Persistence.WirelessRepo.WirelessCommands
{
    public class PlansCommandRepository : IPlansCommandRepository
    {
        public Task<Plans> AddAsyncReturnByEntity<TEntity>(TEntity entity) where TEntity : class
        {
            throw new NotImplementedException();
        }

        public Task<int> AddAsyncReturnById<TEntity>(TEntity entity) where TEntity : class
        {
            throw new NotImplementedException();
        }

        public Task<Plans> DeleteAsync<TEntity>(TEntity entity) where TEntity : class
        {
            throw new NotImplementedException();
        }

        public Task<Plans> UpdateAsyncReturnByEntity<TEntity>(TEntity entity) where TEntity : class
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAsyncReturnById<TEntity>(TEntity entity) where TEntity : class
        {
            throw new NotImplementedException();
        }
    }
}
