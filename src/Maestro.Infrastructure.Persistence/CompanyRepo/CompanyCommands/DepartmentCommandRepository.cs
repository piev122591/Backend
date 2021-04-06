using AutoMapper;
using Maestro.Core.Interfaces;
using Maestro.Core.Interfaces.IDepartmentRepo;
using Maestro.Domain.Entities.Company;
using Maestro.Infrastructure.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Maestro.Infrastructure.CompanyRepo.CompanyCommands
{
    public class DepartmentCommandRepository : IDepartmentCommandRepository
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public DepartmentCommandRepository(IUnitOfWork unitofwork, IMapper mapper)
        {
            this._unitOfWork = unitofwork;
            this._mapper = mapper;
        }

        public async Task<Department> AddAsyncReturnByEntity<TEntity>(TEntity entity) where TEntity : class
        {
            _unitOfWork.BeginTransaction();

            var repo = this._unitOfWork.GetRepository<Department>();

            var department = _mapper.Map<Department>(entity);

            var result = await repo.InsertAsyncReturnByEntity(department);

            _unitOfWork.Commit();

            return result;
        }

        public async Task<int> AddAsyncReturnById<TEntity>(TEntity entity) where TEntity : class
        {
            _unitOfWork.BeginTransaction();

            var repo = this._unitOfWork.GetRepository<Department>();

            var department = _mapper.Map<Department>(entity);

            var result = await repo.InsertAsyncReturnById(department);

            _unitOfWork.Commit();

            return result;
        }

        public async Task<Department> UpdateAsyncReturnByEntity<TEntity>(TEntity entity) where TEntity : class
        {
            _unitOfWork.BeginTransaction();

            var repo = this._unitOfWork.GetRepository<Department>();

            var department = _mapper.Map<Department>(entity);

            var result = await repo.UpdateAsnycReturnByEntity(department);

            _unitOfWork.Commit();

            return result;

        }

        public async Task<int> UpdateAsyncReturnById<TEntity>(TEntity entity) where TEntity : class
        {
            _unitOfWork.BeginTransaction();

            var repo = this._unitOfWork.GetRepository<Department>();

            var department = _mapper.Map<Department>(entity);

            var result = await repo.UpdateAsnycReturnById(department);

            _unitOfWork.Commit();

            return result;
        }


        public Task<Department> DeleteAsync<TEntity>(TEntity entity) where TEntity : class
        {
            throw new NotImplementedException();
        }

    }

    
}
