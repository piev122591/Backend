using Maestro.Core.Interfaces.IAppRepo.INavLinkDefaultPermissionRepo;
using Maestro.Domain.Admin.App;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Maestro.Infrastructure.Persistence.AppRepo.AppQueries
{
    public class NavLinkDefaultPermissionQueryRepository : INavLinkDefaultPermissionQueryRepository
    {
        public Task<List<NavLinkDefaultPermission>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<NavLinkDefaultPermission> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
