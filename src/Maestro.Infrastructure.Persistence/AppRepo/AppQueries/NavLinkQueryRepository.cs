using Maestro.Core.Interfaces.IAppRepo.INavLinkRepo;
using Maestro.Domain.Admin.App;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Maestro.Infrastructure.Persistence.AppRepo.AppQueries
{
    public class NavLinkQueryRepository : INavLinkQueryRepository
    {
        public Task<List<NavLink>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<NavLink> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
