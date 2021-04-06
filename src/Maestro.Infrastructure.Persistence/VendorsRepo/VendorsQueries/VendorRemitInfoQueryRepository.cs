using Maestro.Core.Interfaces.IVendorsRepo.IVendorsRemitInfoRepo;
using Maestro.Domain.Admin.Vendor;
using Maestro.Infrastructure.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Maestro.Infrastructure.Persistence.VendorsRepo.VendorsQueries
{
    public class VendorRemitInfoQueryRepository : IVendorRemitInfoQueryRepository
    {
        private readonly IUnitOfWork _unitOfWork;

        public VendorRemitInfoQueryRepository(IUnitOfWork unitofwork)
        {
            this._unitOfWork = unitofwork;
        }


        public async Task<List<VendorRemitInfo>> GetAllAsync()
        {
            _unitOfWork.BeginTransaction();

            var repo = this._unitOfWork.GetRepository<VendorRemitInfo>();

            var result = await repo.SelectAllAsync();

            return result;
        }

        public async Task<VendorRemitInfo> GetByIdAsync(int id)
        {
            _unitOfWork.BeginTransaction();

            var repo = this._unitOfWork.GetRepository<VendorRemitInfo>();

            var result = await repo.FindByIdAsync(id);

            return result;

        }
    }
}
