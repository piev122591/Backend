using Maestro.Core.Interfaces.IEDIRepo.ICarrierFileImportFieldsRepo;
using Maestro.Domain.Entities.EDI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Maestro.Infrastructure.Persistence.EDIRepo.EDIQueries
{
    public class CarrierFileImportFieldsQueryRepository : ICarrierFileImportFieldsQueryRepository
    {
        public Task<List<CarrierFileImportFields>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<CarrierFileImportFields> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
