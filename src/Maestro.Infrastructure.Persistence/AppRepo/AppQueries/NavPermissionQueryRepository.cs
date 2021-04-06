using Maestro.Core.Interfaces.IAppRepo.INavPermissionRepo;
using Maestro.Domain.Admin.App;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Maestro.Infrastructure.Persistence.AppRepo.AppQueries
{
    public class NavPermissionQueryRepository : INavPermissionQueryRepository
    {
        public Task<List<NavPermission>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<NavPermission> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
