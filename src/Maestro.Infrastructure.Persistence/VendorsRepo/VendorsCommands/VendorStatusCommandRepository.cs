using AutoMapper;
using Maestro.Core.Interfaces.IVendorsRepo.IVendorsStatusRepo;
using Maestro.Domain.Entities.Vendor;
using Maestro.Infrastructure.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Maestro.Infrastructure.Persistence.VendorsRepo.VendorsCommands
{
    public class VendorStatusCommandRepository : IVendorStatusCommandRepository
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public VendorStatusCommandRepository(IUnitOfWork unitofwork, IMapper mapper)
        {
            this._unitOfWork = unitofwork;
            this._mapper = mapper;
        }

        public async Task<VendorStatus> AddAsyncReturnByEntity<TEntity>(TEntity entity) where TEntity : class
        {
            _unitOfWork.BeginTransaction();

            var repo = this._unitOfWork.GetRepository<VendorStatus>();

            var department = _mapper.Map<VendorStatus>(entity);

            var result = await repo.InsertAsyncReturnByEntity(department);

            _unitOfWork.Commit();

            return result;
        }

        public async Task<int> AddAsyncReturnById<TEntity>(TEntity entity) where TEntity : class
        {
            _unitOfWork.BeginTransaction();

            var repo = this._unitOfWork.GetRepository<VendorStatus>();

            var department = _mapper.Map<VendorStatus>(entity);

            var result = await repo.InsertAsyncReturnById(department);

            _unitOfWork.Commit();

            return result;
        }

        public async Task<VendorStatus> UpdateAsyncReturnByEntity<TEntity>(TEntity entity) where TEntity : class
        {
            _unitOfWork.BeginTransaction();

            var repo = this._unitOfWork.GetRepository<VendorStatus>();

            var department = _mapper.Map<VendorStatus>(entity);

            var result = await repo.UpdateAsnycReturnByEntity(department);

            _unitOfWork.Commit();

            return result;
        }

        public async Task<int> UpdateAsyncReturnById<TEntity>(TEntity entity) where TEntity : class
        {
            _unitOfWork.BeginTransaction();

            var repo = this._unitOfWork.GetRepository<VendorStatus>();

            var department = _mapper.Map<VendorStatus>(entity);

            var result = await repo.UpdateAsnycReturnById(department);

            _unitOfWork.Commit();

            return result;
        }

        public Task<VendorStatus> DeleteAsync<TEntity>(TEntity entity) where TEntity : class
        {
            throw new NotImplementedException();
        }
    }

}
