using Maestro.Core.Interfaces.IAppRepo.INavLinkDefaultPermissionRepo;
using Maestro.Domain.Admin.App;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Maestro.Infrastructure.Persistence.AppRepo.AppCommands
{
    public class NavLinkDefaultPermissionCommandRepository : INavLinkDefaultPermissionCommandRepository
    {
        public Task<NavLinkDefaultPermission> AddAsyncReturnByEntity<TEntity>(TEntity entity) where TEntity : class
        {
            throw new NotImplementedException();
        }

        public Task<int> AddAsyncReturnById<TEntity>(TEntity entity) where TEntity : class
        {
            throw new NotImplementedException();
        }

        public Task<NavLinkDefaultPermission> DeleteAsync<TEntity>(TEntity entity) where TEntity : class
        {
            throw new NotImplementedException();
        }

        public Task<NavLinkDefaultPermission> UpdateAsyncReturnByEntity<TEntity>(TEntity entity) where TEntity : class
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAsyncReturnById<TEntity>(TEntity entity) where TEntity : class
        {
            throw new NotImplementedException();
        }
    }
}
