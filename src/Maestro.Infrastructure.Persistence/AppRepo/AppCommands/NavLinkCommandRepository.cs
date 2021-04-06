using Maestro.Core.Interfaces.IAppRepo.INavLinkRepo;
using Maestro.Domain.Admin.App;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Maestro.Infrastructure.Persistence.AppRepo.AppCommands
{
    public class NavLinkCommandRepository : INavLinkCommandRepository
    {
        public Task<NavLink> AddAsyncReturnByEntity<TEntity>(TEntity entity) where TEntity : class
        {
            throw new NotImplementedException();
        }

        public Task<int> AddAsyncReturnById<TEntity>(TEntity entity) where TEntity : class
        {
            throw new NotImplementedException();
        }

        public Task<NavLink> DeleteAsync<TEntity>(TEntity entity) where TEntity : class
        {
            throw new NotImplementedException();
        }

        public Task<NavLink> UpdateAsyncReturnByEntity<TEntity>(TEntity entity) where TEntity : class
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAsyncReturnById<TEntity>(TEntity entity) where TEntity : class
        {
            throw new NotImplementedException();
        }
    }
}
