
using Maestro.Shared.DatabaseAttributes.SQLTable;
using System;
using System.Collections.Generic;
using System.Text;

namespace Maestro.Domain.Admin.Asset
{
    [DBSchema("asset")]
    public class BaseDeviceStatus : BaseEntity
    {
        public int BaseDeviceStatusId { get; set; }
        public string BaseDeviceStatusDescription { get; set; }
        public bool IsDeleted { get; set; }
        public ICollection<BaseDevice> BaseDevice { get; set; }
    }
}
