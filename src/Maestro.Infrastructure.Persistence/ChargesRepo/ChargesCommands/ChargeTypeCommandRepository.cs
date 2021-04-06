using Maestro.Core.Interfaces.IChargesRepo.IChargeTypeRepo;
using Maestro.Domain.Admin.Charges;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Maestro.Infrastructure.Persistence.ChargesRepo.ChargesCommands
{
    public class ChargeTypeCommandRepository : IChargeTypeCommandRepository
    {
        public Task<ChargeType> AddAsyncReturnByEntity<TEntity>(TEntity entity) where TEntity : class
        {
            throw new NotImplementedException();
        }

        public Task<int> AddAsyncReturnById<TEntity>(TEntity entity) where TEntity : class
        {
            throw new NotImplementedException();
        }

        public Task<ChargeType> DeleteAsync<TEntity>(TEntity entity) where TEntity : class
        {
            throw new NotImplementedException();
        }

        public Task<ChargeType> UpdateAsyncReturnByEntity<TEntity>(TEntity entity) where TEntity : class
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAsyncReturnById<TEntity>(TEntity entity) where TEntity : class
        {
            throw new NotImplementedException();
        }
    }
}
