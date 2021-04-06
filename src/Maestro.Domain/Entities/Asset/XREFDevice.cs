using Maestro.Domain.Admin.Vendor;
using Maestro.Shared.DatabaseAttributes.SQLTable;
using System;
using System.Collections.Generic;
using System.Text;

namespace Maestro.Domain.Admin.Asset
{
    [DBSchema("asset")]
    public class XREFDevice : BaseEntity
    {
        public int XREFID { get; set; }
        public int VendorId { get; set; }
        public string DeviceMake { get; set; }
        public string DeviceModel { get; set; }
        public int BaseDeviceId { get; set; }
        public bool IsDeleted { get; set; }
        public Vendors Vendors { get; set; }
        public BaseDevice BaseDevice { get; set; }

    }
}
