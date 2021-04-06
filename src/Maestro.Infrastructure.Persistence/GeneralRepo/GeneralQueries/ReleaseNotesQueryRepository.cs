using Maestro.Core.Interfaces.IGeneralRepo.IReleaseNotesRepo;
using Maestro.Domain.Entities.General;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Maestro.Infrastructure.Persistence.GeneralRepo.GeneralQueries
{
    public class ReleaseNotesQueryRepository : IReleaseNotesQueryRepository
    {
        public Task<List<ReleaseNotes>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ReleaseNotes> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
