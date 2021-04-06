using Maestro.Core.Interfaces.IAppRepo.IPermissionRepo;
using Maestro.Domain.Admin.App;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Maestro.Infrastructure.Persistence.AppRepo.AppQueries
{
    public class PermissionQueryRepository : IPermissionQueryRepository
    {
        public Task<List<Permission>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Permission> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
