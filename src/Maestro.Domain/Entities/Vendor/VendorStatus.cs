using System;
using System.Collections.Generic;
using System.Text;

namespace Maestro.Domain.Entities.Vendor
{
    public class VendorStatus : BaseEntity
    {
        public int VendorStatusId { get; set; }
        public string StatusDescription { get; set; }
    }
}
