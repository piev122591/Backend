using Maestro.Core.Interfaces.IServicesRepo.IServiceTypeRepo;
using Maestro.Domain.Entities.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Maestro.Infrastructure.Persistence.ServicesRepo.ServicesQueries
{
    public class ServiceTypeQueryRepository : IServiceTypeQueryRepository
    {
        public Task<List<ServiceType>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ServiceType> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
