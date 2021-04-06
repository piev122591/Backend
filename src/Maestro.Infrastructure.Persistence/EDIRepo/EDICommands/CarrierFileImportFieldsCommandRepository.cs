using Maestro.Core.Interfaces.IEDIRepo.ICarrierFileImportFieldsRepo;
using Maestro.Domain.Entities.EDI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Maestro.Infrastructure.Persistence.EDIRepo.EDICommands
{
    public class CarrierFileImportFieldsCommandRepository : ICarrierFileImportFieldsCommandRepository
    {
        public Task<CarrierFileImportFields> AddAsyncReturnByEntity<TEntity>(TEntity entity) where TEntity : class
        {
            throw new NotImplementedException();
        }

        public Task<int> AddAsyncReturnById<TEntity>(TEntity entity) where TEntity : class
        {
            throw new NotImplementedException();
        }

        public Task<CarrierFileImportFields> DeleteAsync<TEntity>(TEntity entity) where TEntity : class
        {
            throw new NotImplementedException();
        }

        public Task<CarrierFileImportFields> UpdateAsyncReturnByEntity<TEntity>(TEntity entity) where TEntity : class
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAsyncReturnById<TEntity>(TEntity entity) where TEntity : class
        {
            throw new NotImplementedException();
        }
    }
}
