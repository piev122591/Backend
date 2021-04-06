using Maestro.Core.Interfaces.IChargesRepo.IChargeCodeRepo;
using Maestro.Domain.Admin.Charges;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Maestro.Infrastructure.Persistence.ChargesRepo.ChargesQueries
{
    public class ChargeCodeQueryRepository : IChargeCodeQueryRepository
    {
        public Task<List<ChargeCode>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ChargeCode> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
