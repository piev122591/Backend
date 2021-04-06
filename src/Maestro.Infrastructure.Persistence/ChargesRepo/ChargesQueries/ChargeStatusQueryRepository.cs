using Maestro.Core.Interfaces.IChargesRepo.IChargeStatusRepo;
using Maestro.Domain.Entities.Charges;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Maestro.Infrastructure.Persistence.ChargesRepo.ChargesQueries
{
    public class ChargeStatusQueryRepository : IChargeStatusQueryRepository
    {
        public Task<List<ChargeStatus>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ChargeStatus> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
