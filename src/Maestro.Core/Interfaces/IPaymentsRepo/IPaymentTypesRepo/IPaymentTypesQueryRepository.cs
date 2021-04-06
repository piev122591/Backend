using Maestro.Domain.Entities.Payments;
using System;
using System.Collections.Generic;
using System.Text;

namespace Maestro.Core.Interfaces.IPaymentsRepo.IPaymentTypesRepo
{
    public interface IPaymentTypesQueryRepository : IQueryRepository<PaymentTypes>
    {
    }
}
