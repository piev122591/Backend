using Maestro.Core.Interfaces.IPaymentsRepo.IPaymentMethodStatusRepo;
using Maestro.Domain.Entities.Payments;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Maestro.Infrastructure.Persistence.PaymentsRepo.PaymentsQueries
{
    public class PaymentMethodStatusQueryRepository : IPaymentMethodStatusQueryRepository
    {
        public Task<List<PaymentMethodStatus>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<PaymentMethodStatus> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
