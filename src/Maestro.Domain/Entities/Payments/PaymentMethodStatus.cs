using System;
using System.Collections.Generic;
using System.Text;

namespace Maestro.Domain.Entities.Payments
{
    public class PaymentMethodStatus : BaseEntity
    {
        public int PaymentMethodStatusId { get; set; }
        public string PaymentMethodStatusDescription { get; set; }
        public bool IsDeleted { get; set; }
    }
}
