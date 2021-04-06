using Maestro.Core.Interfaces.IServicesRepo.IServiceSubTypeStatusRepo;
using Maestro.Domain.Entities.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Maestro.Infrastructure.Persistence.ServicesRepo.ServicesQueries
{
    public class ServiceSubTypeStatusQueryRepository : IServiceSubTypeStatusQueryRepository
    {
        public Task<List<ServiceSubTypeStatus>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ServiceSubTypeStatus> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
