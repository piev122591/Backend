using Maestro.Domain.Entities.Payments;
using System;
using System.Collections.Generic;
using System.Text;

namespace Maestro.Core.Interfaces.IPaymentsRepo.IPaymentTypeStatusRepo
{
    public interface IPaymentTypeStatusQueryRepository : IQueryRepository<PaymentTypeStatus>
    {
    }
}
