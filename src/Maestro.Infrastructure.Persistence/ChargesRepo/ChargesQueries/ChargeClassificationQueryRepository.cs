using Maestro.Core.Interfaces.IChargesRepo.IChargeClassificationRepo;
using Maestro.Domain.Admin.Charges;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Maestro.Infrastructure.Persistence.ChargesRepo.ChargesQueries
{
    public class ChargeClassificationQueryRepository : IChargeClassificationQueryRepository
    {
        public Task<List<ChargeClassification>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ChargeClassification> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
