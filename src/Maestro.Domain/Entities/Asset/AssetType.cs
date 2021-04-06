
using Maestro.Shared.DatabaseAttributes.SQLTable;
using System;
using System.Collections.Generic;
using System.Text;

namespace Maestro.Domain.Admin.Asset
{
    [DBSchema("asset")]
    public class AssetType : BaseEntity
    {
        public int AssetTypeId { get; set; }
        public string AssetTypeDescription { get; set; }
        public bool IsWireless { get; set; }
        public int AssetStatusId { get; set; }
        public bool IsDeleted { get; set; }
        public AssetTypeStatus AssetTypeStatus { get; set; }
        public ICollection<BaseDevice> BaseDevice { get; set; }
    }
}
