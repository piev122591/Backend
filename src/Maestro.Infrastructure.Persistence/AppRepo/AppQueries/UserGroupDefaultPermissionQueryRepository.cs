using Maestro.Core.Interfaces.IAppRepo.IUserGroupDefaultPermissionRepo;
using Maestro.Domain.Admin.App;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Maestro.Infrastructure.Persistence.AppRepo.AppQueries
{
    public class UserGroupDefaultPermissionQueryRepository : IUserGroupDefaultPermissionQueryRepository
    {
        public Task<List<UserGroupDefaultPermission>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<UserGroupDefaultPermission> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
