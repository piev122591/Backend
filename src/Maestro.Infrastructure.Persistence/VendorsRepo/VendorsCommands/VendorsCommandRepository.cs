using AutoMapper;
using Maestro.Core.Interfaces.IVendorsRepo.IVendorsRepo;
using Maestro.Domain.Admin.Vendor;
using Maestro.Infrastructure.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Maestro.Infrastructure.Persistence.VendorsRepo.VendorsCommands
{

    public class VendorsCommandRepository : IVendorsCommandRepository
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public VendorsCommandRepository(IUnitOfWork unitofwork, IMapper mapper)
        {
            this._unitOfWork = unitofwork;
            this._mapper = mapper;
        }


        public async Task<Vendors> AddAsyncReturnByEntity<TEntity>(TEntity entity) where TEntity : class
        {
            _unitOfWork.BeginTransaction();

            var repo = this._unitOfWork.GetRepository<Vendors>();

            var vendors = _mapper.Map<Vendors>(entity);

            var result = await repo.InsertAsyncReturnByEntity(vendors);

            _unitOfWork.Commit();

            return result;


        }

        public async Task<int> AddAsyncReturnById<TEntity>(TEntity entity) where TEntity : class
        {
            _unitOfWork.BeginTransaction();

            var repo = this._unitOfWork.GetRepository<Vendors>();

            var vendors = _mapper.Map<Vendors>(entity);

            var result = await repo.InsertAsyncReturnById(vendors);

            _unitOfWork.Commit();

            return result;
        }

        public async Task<Vendors> UpdateAsyncReturnByEntity<TEntity>(TEntity entity) where TEntity : class
        {
            _unitOfWork.BeginTransaction();

            var repo = this._unitOfWork.GetRepository<Vendors>();

            var vendors = _mapper.Map<Vendors>(entity);

            var result = await repo.UpdateAsnycReturnByEntity(vendors);

            _unitOfWork.Commit();

            return result;
        }

        public async Task<int> UpdateAsyncReturnById<TEntity>(TEntity entity) where TEntity : class
        {
            _unitOfWork.BeginTransaction();

            var repo = this._unitOfWork.GetRepository<Vendors>();

            var vendors = _mapper.Map<Vendors>(entity);

            var result = await repo.UpdateAsnycReturnById(vendors);

            _unitOfWork.Commit();

            return result;
        }

        public Task<Vendors> DeleteAsync<TEntity>(TEntity entity) where TEntity : class
        {
            throw new NotImplementedException();
        }
    }
}
