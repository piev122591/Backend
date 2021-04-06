using Maestro.Domain.Entities.Payments;
using System;
using System.Collections.Generic;
using System.Text;

namespace Maestro.Core.Interfaces.IPaymentsRepo.IPaymentMethodRepo
{
    public interface IPaymentMethodQueryRepository : IQueryRepository<PaymentMethod>
    {
    }
}
