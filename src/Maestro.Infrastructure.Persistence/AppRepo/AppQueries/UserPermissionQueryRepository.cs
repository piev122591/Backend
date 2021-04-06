using Maestro.Core.Interfaces.IAppRepo.IUserPermissionRepo;
using Maestro.Domain.Admin.App;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Maestro.Infrastructure.Persistence.AppRepo.AppQueries
{
    public class UserPermissionQueryRepository : IUserPermissionQueryRepository
    {
        public Task<List<UserPermission>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<UserPermission> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
