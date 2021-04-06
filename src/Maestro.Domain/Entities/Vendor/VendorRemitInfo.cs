using Maestro.Shared.DatabaseAttributes.SQLTable;
using System;
using System.Collections.Generic;
using System.Text;

namespace Maestro.Domain.Admin.Vendor
{
    [DBSchema("vendor")]
    public class VendorRemitInfo : BaseEntity
    {
        public int RemitId { get; set; }
        public string POBox { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string zip { get; set; }
        public int Status { get; set; }
        public int VendorId { get; set; }
        public bool IsDeleted { get; set; }
        public Vendors Vendors { get; set; }

    }
}
