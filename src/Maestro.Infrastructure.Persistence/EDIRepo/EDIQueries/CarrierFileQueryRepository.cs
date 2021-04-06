using Maestro.Core.Interfaces.IEDIRepo.ICarrierFileRepo;
using Maestro.Domain.Entities.EDI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Maestro.Infrastructure.Persistence.EDIRepo.EDIQueries
{
    public class CarrierFileQueryRepository : ICarrierFileQueryRepository
    {
        public Task<List<CarrierFile>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<CarrierFile> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
