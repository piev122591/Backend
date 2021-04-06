using Maestro.Core.Mappings;
using Maestro.Domain;
using Maestro.Domain.Admin.Vendor;
using System;
using System.Collections.Generic;
using System.Text;

namespace Maestro.Core.Features.VendorsFeature.VendorsFeature.Command.AddVendors
{
    public class AddVendorsVM : BaseEntity,IMapSource<Vendors>
    {
        public int VendorId { get; set; }
        public string CarrierName { get; set; }
        public int Status { get; set; }
        public bool IsWireless { get; set; }
        public bool IsWireline { get; set; }
        public bool UseselectronicData { get; set; }
        public bool IsDeleted { get; set; }
    }
}
