using Maestro.Shared.DatabaseAttributes.SQLTable;
using System;
using System.Collections.Generic;
using System.Text;

namespace Maestro.Domain.Admin.Asset
{

    [DBSchema("asset")]
    public class BaseDevice : BaseEntity
    {
        public int BaseDeviceId { get; set; }
        public int VendorId { get; set; }
        public string DeviceMake { get; set; }
        public string DeviceModel { get; set; }
        public string DevicePath { get; set; }
        public string DeviceImage { get; set; }
        public int AssetTypeId { get; set; }
        public int BaseDeviceStatusId { get; set; }
        public AssetType AssetType { get; set; }
        public BaseDeviceStatus BaseDeviceStatus { get; set; }
        public ICollection<XREFDevice> XREFDevice { get; set; }

    }
}
