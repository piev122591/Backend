using Maestro.Core.Interfaces.IVendorsRepo.IVendorsRepo;
using Maestro.Domain.Admin.Vendor;
using Maestro.Infrastructure.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Maestro.Infrastructure.Persistence.VendorsRepo.VendorsQueries
{
    public class VendorsQueryRepository : IVendorsQueryRepository
    {
        private readonly IUnitOfWork _unitOfWork;


        public VendorsQueryRepository(IUnitOfWork unitofwork)
        {
            this._unitOfWork = unitofwork;
        }

        public async Task<List<Vendors>> GetAllAsync()
        {
            _unitOfWork.BeginTransaction();

            var repo = this._unitOfWork.GetRepository<Vendors>();

            var result = await repo.SelectAllAsync();

            return result;
        }

        public async Task<Vendors> GetByIdAsync(int id)
        {
            _unitOfWork.BeginTransaction();

            var repo = this._unitOfWork.GetRepository<Vendors>();

            var result = await repo.FindByIdAsync(id);

            return result;
        }

    }
}
