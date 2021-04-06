using Maestro.Core.Interfaces.IWirelessRepo.IPlansRepo;
using Maestro.Domain.Entities.Wireless;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Maestro.Infrastructure.Persistence.WirelessRepo.WirelessQueries
{
    public class PlansQueryRepository : IPlansQueryRepository
    {
        public Task<List<Plans>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Plans> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
