using Maestro.Core.Interfaces.IPaymentsRepo.IPaymentTypeStatusRepo;
using Maestro.Domain.Entities.Payments;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Maestro.Infrastructure.Persistence.PaymentsRepo.PaymentsQueries
{
    public class PaymentTypeStatusQueryRepository : IPaymentTypeStatusQueryRepository
    {
        public Task<List<PaymentTypeStatus>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<PaymentTypeStatus> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
