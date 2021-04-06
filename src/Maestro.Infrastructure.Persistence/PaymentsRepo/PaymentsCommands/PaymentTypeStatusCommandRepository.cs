using Maestro.Core.Interfaces.IPaymentsRepo.IPaymentTypeStatusRepo;
using Maestro.Domain.Entities.Payments;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Maestro.Infrastructure.Persistence.PaymentsRepo.PaymentsCommands
{
    public class PaymentTypeStatusCommandRepository : IPaymentTypeStatusCommandRepository
    {
        public Task<PaymentTypeStatus> AddAsyncReturnByEntity<TEntity>(TEntity entity) where TEntity : class
        {
            throw new NotImplementedException();
        }

        public Task<int> AddAsyncReturnById<TEntity>(TEntity entity) where TEntity : class
        {
            throw new NotImplementedException();
        }

        public Task<PaymentTypeStatus> DeleteAsync<TEntity>(TEntity entity) where TEntity : class
        {
            throw new NotImplementedException();
        }

        public Task<PaymentTypeStatus> UpdateAsyncReturnByEntity<TEntity>(TEntity entity) where TEntity : class
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAsyncReturnById<TEntity>(TEntity entity) where TEntity : class
        {
            throw new NotImplementedException();
        }
    }
}
