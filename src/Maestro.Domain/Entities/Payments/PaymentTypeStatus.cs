using System;
using System.Collections.Generic;
using System.Text;

namespace Maestro.Domain.Entities.Payments
{
    public class PaymentTypeStatus : BaseEntity
    {
        public int PaymentTypeStatusId { get; set; }
        public string PaymentTypeStatusDescription { get; set; }
        public bool IsDeleted { get; set; }

    }
}
