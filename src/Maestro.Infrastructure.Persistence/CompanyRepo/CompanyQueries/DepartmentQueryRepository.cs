using Maestro.Core.Interfaces.IDepartmentRepo;
using Maestro.Domain.Entities.Company;
using Maestro.Infrastructure.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Maestro.Infrastructure.CompanyRepo.CompanyQueries
{ 
    public class DepartmentQueryRepository : IDepartmentQueryRepository
    {
        private readonly IUnitOfWork _unitOfWork;
        public DepartmentQueryRepository(IUnitOfWork unitofwork)
        {
            this._unitOfWork = unitofwork;
        }
        public async Task<List<Department>> GetAllAsync()
        {
            _unitOfWork.BeginTransaction();

            var repo = this._unitOfWork.GetRepository<Department>();

            var result = await repo.SelectAllAsync();

            return result;
        }

        public async Task<Department> GetByIdAsync(int id)
        {
            _unitOfWork.BeginTransaction();

            var repo = this._unitOfWork.GetRepository<Department>();

            var result = await repo.FindByIdAsync(id);

            return result;
        }
    }
}
