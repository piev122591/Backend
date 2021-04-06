using Maestro.Core.Interfaces.IServicesRepo.IServiceTypeRepo;
using Maestro.Domain.Entities.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Maestro.Infrastructure.Persistence.ServicesRepo.ServicesCommands
{
    public class ServiceTypeCommandRepository : IServiceTypeCommandRepository
    {
        public Task<ServiceType> AddAsyncReturnByEntity<TEntity>(TEntity entity) where TEntity : class
        {
            throw new NotImplementedException();
        }

        public Task<int> AddAsyncReturnById<TEntity>(TEntity entity) where TEntity : class
        {
            throw new NotImplementedException();
        }

        public Task<ServiceType> DeleteAsync<TEntity>(TEntity entity) where TEntity : class
        {
            throw new NotImplementedException();
        }

        public Task<ServiceType> UpdateAsyncReturnByEntity<TEntity>(TEntity entity) where TEntity : class
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAsyncReturnById<TEntity>(TEntity entity) where TEntity : class
        {
            throw new NotImplementedException();
        }
    }
}
