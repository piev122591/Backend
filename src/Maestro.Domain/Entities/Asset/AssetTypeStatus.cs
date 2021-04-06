using Maestro.Shared.DatabaseAttributes.SQLTable;
using System;
using System.Collections.Generic;
using System.Text;

namespace Maestro.Domain.Admin.Asset
{
    [DBSchema("asset")]
    public class AssetTypeStatus : BaseEntity
    {
        public int AssetStatusId { get; set; }
        public string AssetStatusDescription { get; set; }
        public bool IsDeleted { get; set; }
        public ICollection<AssetType> AssetType { get; set; }
    }
}
