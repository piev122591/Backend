using System;
using System.Collections.Generic;
using System.Text;

namespace Maestro.Domain.Entities.Payments
{
    public class PaymentMethod : BaseEntity
    {
        public int PaymentMethodId { get; set; }
        public string PaymentMethodDescription { get; set; }
        public int PaymentTypeId { get; set; }
        public int PaymentMethodStatusId { get; set; }
        public bool IsDeleted { get; set; }

    }
}
