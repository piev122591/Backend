using Maestro.Domain.Admin.Asset;
using Maestro.Shared.DatabaseAttributes.SQLTable;
using System;
using System.Collections.Generic;
using System.Text;

namespace Maestro.Domain.Admin.Vendor
{
    [DBSchema("vendor")]
    public class Vendors : BaseEntity
    {
        public int VendorId { get; set; }
        public string CarrierName { get; set; }
        public int Status { get; set; }
        public bool IsWireless { get; set; }
        public bool IsWireline { get; set; }
        public bool UseselectronicData { get; set; } 
        public bool IsDeleted { get; set; }
        public ICollection<VendorRemitInfo> VendorRemitInfo { get; set; }
        public ICollection<XREFDevice> XREFDevice { get; set; }
    }
}
