using Maestro.Core.Interfaces.IServicesRepo.IServiceTypeStatusRepo;
using Maestro.Domain.Entities.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Maestro.Infrastructure.Persistence.ServicesRepo.ServicesQueries
{
    public class ServiceTypeStatusQueryRepository : IServiceTypeStatusQueryRepository
    {
        public Task<List<ServiceTypeStatus>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ServiceTypeStatus> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
