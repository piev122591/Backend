using AutoMapper;
using Maestro.Core.Interfaces.IVendorsRepo.IVendorsRemitInfoRepo;
using Maestro.Domain.Admin.Vendor;
using Maestro.Infrastructure.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Maestro.Infrastructure.Persistence.VendorsRepo
{
    public class VendorRemitInfoComandRepository : IVendorRemitInfoCommandRepository
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public VendorRemitInfoComandRepository(IUnitOfWork unitofwork, IMapper mapper)
        {
            this._unitOfWork = unitofwork;
            this._mapper = mapper;
        }


        public async Task<VendorRemitInfo> AddAsyncReturnByEntity<TEntity>(TEntity entity) where TEntity : class
        {
            _unitOfWork.BeginTransaction();

            var repo = this._unitOfWork.GetRepository<VendorRemitInfo>();

            var vendorsinfo = _mapper.Map<VendorRemitInfo>(entity);

            var result = await repo.InsertAsyncReturnByEntity(vendorsinfo);

            _unitOfWork.Commit();

            return result;

        }

        public async Task<int> AddAsyncReturnById<TEntity>(TEntity entity) where TEntity : class
        {
            _unitOfWork.BeginTransaction();

            var repo = this._unitOfWork.GetRepository<VendorRemitInfo>();

            var vendorsinfo = _mapper.Map<VendorRemitInfo>(entity);

            var result = await repo.InsertAsyncReturnById(vendorsinfo);

            _unitOfWork.Commit();

            return result;
        }

        public async Task<VendorRemitInfo> UpdateAsyncReturnByEntity<TEntity>(TEntity entity) where TEntity : class
        {
            _unitOfWork.BeginTransaction();

            var repo = this._unitOfWork.GetRepository<VendorRemitInfo>();

            var vendorsinfo = _mapper.Map<VendorRemitInfo>(entity);

            var result = await repo.UpdateAsnycReturnByEntity(vendorsinfo);

            _unitOfWork.Commit();

            return result;
        }

        public async Task<int> UpdateAsyncReturnById<TEntity>(TEntity entity) where TEntity : class
        {
            _unitOfWork.BeginTransaction();

            var repo = this._unitOfWork.GetRepository<VendorRemitInfo>();

            var vendorsinfo = _mapper.Map<VendorRemitInfo>(entity);

            var result = await repo.UpdateAsnycReturnById(vendorsinfo);

            _unitOfWork.Commit();

            return result;
        }

        public Task<VendorRemitInfo> DeleteAsync<TEntity>(TEntity entity) where TEntity : class
        {
            throw new NotImplementedException();
        }
    }
}
