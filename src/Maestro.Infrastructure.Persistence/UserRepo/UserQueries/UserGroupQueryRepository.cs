using Maestro.Core.Interfaces.IUserRepo.IUserGroupRepo;
using Maestro.Domain.Admin.Users;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Maestro.Infrastructure.Persistence.UserRepo.UserQueries
{
    public class UserGroupQueryRepository : IUserGroupQueryRepository
    {
        public Task<List<UserGroup>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<UserGroup> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
