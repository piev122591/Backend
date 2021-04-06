using Maestro.Core.Interfaces.IChargesRepo.IXREFChargesRepo;
using Maestro.Domain.Entities.Charges;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Maestro.Infrastructure.Persistence.ChargesRepo.ChargesQueries
{
    public class XREFChargesQueryRepository : IXREFChargesQueryRepository
    {
        public Task<List<XREFCharges>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<XREFCharges> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
