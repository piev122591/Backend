using Maestro.Core.Interfaces.ICompanyRepo.IMainListRepo;
using Maestro.Domain.Entities.Company;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Maestro.Infrastructure.Persistence.CompanyRepo.CompanyCommands
{
    public class MainListCommandRepository : IMainListCommandRepository
    {
        public Task<MainList> AddAsyncReturnByEntity<TEntity>(TEntity entity) where TEntity : class
        {
            throw new NotImplementedException();
        }

        public Task<int> AddAsyncReturnById<TEntity>(TEntity entity) where TEntity : class
        {
            throw new NotImplementedException();
        }

        public Task<MainList> DeleteAsync<TEntity>(TEntity entity) where TEntity : class
        {
            throw new NotImplementedException();
        }

        public Task<MainList> UpdateAsyncReturnByEntity<TEntity>(TEntity entity) where TEntity : class
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAsyncReturnById<TEntity>(TEntity entity) where TEntity : class
        {
            throw new NotImplementedException();
        }
    }
}
