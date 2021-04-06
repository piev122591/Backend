using System;
using System.Collections.Generic;
using System.Text;

namespace Maestro.Domain.Entities.Wireless
{
    public class PlanTypes : BaseEntity
    {
        public int PlanTypeId { get; set; }
        public string PlanTypeDescription { get; set; }
        public bool IsDeleted { get; set; }
    }
}
