using Maestro.Domain.Entities.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace Maestro.Core.Interfaces.IUserRepo.IUserProfileRepo
{
    public interface IUserProfileCommandRepository : ICommandReporistory<UserProfile>
    {
    }
}
