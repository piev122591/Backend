using Maestro.Core.Interfaces.IUserRepo.IUsersInGroupRepo;
using Maestro.Domain.Admin.Users;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Maestro.Infrastructure.Persistence.UserRepo.UserQueries
{
    public class UsersInGroupQueryRepository : IUsersInGroupQueryRepository
    {
        public Task<List<UsersInGroup>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<UsersInGroup> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
