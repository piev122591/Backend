using System;
using System.Collections.Generic;
using System.Text;

namespace Maestro.Domain.Entities.Wireless
{
    public class PlanStatus : BaseEntity
    {
        public int PlanStatusId { get; set; }
        public string PlanStatusDescription { get; set; }
        public bool IsDeleted { get; set; }
    }
}
