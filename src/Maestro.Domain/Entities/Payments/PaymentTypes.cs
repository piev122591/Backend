using System;
using System.Collections.Generic;
using System.Text;

namespace Maestro.Domain.Entities.Payments
{
    public class PaymentTypes : BaseEntity
    {
        public int PaymentTypeId { get; set; }
        public string PaymentTypeDescription { get; set; }
        public int PaymentTypeStatusId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
