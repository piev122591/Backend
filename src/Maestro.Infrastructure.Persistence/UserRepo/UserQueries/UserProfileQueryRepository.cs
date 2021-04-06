using Maestro.Core.Interfaces.IUserRepo.IUserProfileRepo;
using Maestro.Domain.Entities.Users;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Maestro.Infrastructure.Persistence.UserRepo.UserQueries
{
    public class UserProfileQueryRepository : IUserProfileQueryRepository
    {
        public Task<List<UserProfile>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<UserProfile> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
