using Maestro.Core.Interfaces.IEDIRepo.IProcessTypeStatusRepo;
using Maestro.Domain.Entities.EDI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Maestro.Infrastructure.Persistence.EDIRepo.EDIQueries
{
    public class ProcessTypeStatusQueryRepository : IProcessTypeStatusQueryRepository
    {
        public Task<List<ProcessTypeStatus>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ProcessTypeStatus> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
