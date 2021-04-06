using Maestro.Core.Interfaces.IWirelessRepo.IPlanStatusRepo;
using Maestro.Domain.Entities.Wireless;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Maestro.Infrastructure.Persistence.WirelessRepo.WirelessQueries
{
    public class PlanStatusQueryRepository : IPlanStatusQueryRepository
    {
        public Task<List<PlanStatus>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<PlanStatus> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
