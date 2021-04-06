using Maestro.Core.Interfaces.IChargesRepo.IChargeTypeRepo;
using Maestro.Domain.Admin.Charges;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Maestro.Infrastructure.Persistence.ChargesRepo.ChargesQueries
{
    public class ChargeTypeQueryRepository : IChargeTypeQueryRepository
    {
        public Task<List<ChargeType>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ChargeType> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
