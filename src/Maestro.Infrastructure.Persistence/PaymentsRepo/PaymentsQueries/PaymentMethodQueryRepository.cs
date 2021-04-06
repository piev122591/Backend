using Maestro.Core.Interfaces.IPaymentsRepo.IPaymentMethodRepo;
using Maestro.Domain.Entities.Payments;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Maestro.Infrastructure.Persistence.PaymentsRepo.PaymentsQueries
{
    public class PaymentMethodQueryRepository : IPaymentMethodQueryRepository
    {
        public Task<List<PaymentMethod>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<PaymentMethod> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
