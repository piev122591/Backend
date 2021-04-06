using Maestro.Core.Interfaces.IPaymentsRepo.IPaymentTypesRepo;
using Maestro.Domain.Entities.Payments;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Maestro.Infrastructure.Persistence.PaymentsRepo.PaymentsQueries
{
    public class PaymentTypesQueryRepository : IPaymentTypesQueryRepository
    {
        public Task<List<PaymentTypes>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<PaymentTypes> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
