using Maestro.Core.Interfaces.IWirelessRepo.IPlanTypesRepo;
using Maestro.Domain.Entities.Wireless;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Maestro.Infrastructure.Persistence.WirelessRepo.WirelessQueries
{
    public class PlanTypesQueryRepository : IPlanTypesQueryRepository
    {
        public Task<List<PlanTypes>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<PlanTypes> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
