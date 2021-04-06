using Maestro.Core.Interfaces.IVendorsRepo.IVendorsStatusRepo;
using Maestro.Domain.Entities.Vendor;
using Maestro.Infrastructure.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Maestro.Infrastructure.Persistence.VendorsRepo.VendorsQueries
{
    public class VendorStatusQueryRepository : IVendorStatusQueryRepository
    {
        private readonly IUnitOfWork _unitOfWork;

        public VendorStatusQueryRepository(IUnitOfWork unitofwork)
        {
            this._unitOfWork = unitofwork;
        }
        public async Task<List<VendorStatus>> GetAllAsync()
        {
            _unitOfWork.BeginTransaction();

            var repo = this._unitOfWork.GetRepository<VendorStatus>();

            var result = await repo.SelectAllAsync();

            return result;
        }

        public async Task<VendorStatus> GetByIdAsync(int id)
        {
            _unitOfWork.BeginTransaction();

            var repo = this._unitOfWork.GetRepository<VendorStatus>();

            var result = await repo.FindByIdAsync(id);

            return result;
        }
    }
}
