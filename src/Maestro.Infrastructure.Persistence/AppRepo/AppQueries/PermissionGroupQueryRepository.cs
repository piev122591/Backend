using Maestro.Core.Interfaces.IAppRepo.IPermissionGroupRepo;
using Maestro.Domain.Admin.App;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Maestro.Infrastructure.Persistence.AppRepo.AppQueries
{
    public class PermissionGroupQueryRepository : IPermissionGroupQueryRepository
    {
        public Task<List<PermissionGroup>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<PermissionGroup> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
