using Maestro.Domain.Entities.Payments;
using System;
using System.Collections.Generic;
using System.Text;

namespace Maestro.Core.Interfaces.IPaymentsRepo.IPaymentMethodStatusRepo
{
    public interface IPaymentMethodStatusCommandRepository : ICommandReporistory<PaymentMethodStatus>
    {
    }
}
