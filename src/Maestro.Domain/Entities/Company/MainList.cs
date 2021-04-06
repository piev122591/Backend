
using Maestro.Shared.DatabaseAttributes.SQLTable;
using System;
using System.ComponentModel.DataAnnotations;

namespace Maestro.Domain.Entities.Company
{
    [DBSchema("company")]
    public class MainList : BaseEntity
    {
        [Key()]
        public int CompanyId { get; set; }
        public Guid TenantId { get; set; }
        public Guid CompanyUID { get; set; }
        public string CompanyName { get; set; }
        public int? ParentCompanyId { get; set; }    
        public byte[] RowVer { get; set; }

    }
}
