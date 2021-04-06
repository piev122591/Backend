using System;
using System.Collections.Generic;
using System.Text;

namespace Maestro.Domain.Entities.Wireless
{
    public class Plans : BaseEntity
    {
        public int PlanId { get; set; }
        public string PlanName { get; set; }
        public int VendorId { get; set; }
        public int PlanTypeId { get; set; }
        public int PlanStatusId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
