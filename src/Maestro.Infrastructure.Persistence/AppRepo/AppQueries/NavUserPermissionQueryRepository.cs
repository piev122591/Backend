using Maestro.Core.Interfaces.IAppRepo.INavUserPermissionRepo;
using Maestro.Domain.Admin.App;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Maestro.Infrastructure.Persistence.AppRepo.AppQueries
{
    public class NavUserPermissionQueryRepository : INavUserPermissionQueryRepository
    {
        public Task<List<NavUserPermission>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<NavUserPermission> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
