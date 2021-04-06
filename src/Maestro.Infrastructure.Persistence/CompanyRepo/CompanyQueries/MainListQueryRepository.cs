using Maestro.Core.Interfaces.ICompanyRepo.IMainListRepo;
using Maestro.Domain.Entities.Company;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Maestro.Infrastructure.Persistence.CompanyRepo.CompanyQueries
{
    public class MainListQueryRepository : IMainListQueryRepository
    {
        public Task<List<MainList>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<MainList> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
