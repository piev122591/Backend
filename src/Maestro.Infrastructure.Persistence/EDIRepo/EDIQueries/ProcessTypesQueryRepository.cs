using Maestro.Core.Interfaces.IEDIRepo.IProcessTypesRepo;
using Maestro.Domain.Entities.EDI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Maestro.Infrastructure.Persistence.EDIRepo.EDIQueries
{
    public class ProcessTypesQueryRepository : IProcessTypesQueryRepository
    {
        public Task<List<ProcessTypes>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ProcessTypes> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
