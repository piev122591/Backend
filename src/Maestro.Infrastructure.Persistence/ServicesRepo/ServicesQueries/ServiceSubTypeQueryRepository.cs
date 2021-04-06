using Maestro.Core.Interfaces.IServicesRepo.IServiceSubTypeRepo;
using Maestro.Domain.Entities.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Maestro.Infrastructure.Persistence.ServicesRepo.ServicesQueries
{
    public class ServiceSubTypeQueryRepository : IServiceSubTypeQueryRepository
    {
        public Task<List<ServiceSubType>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ServiceSubType> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
