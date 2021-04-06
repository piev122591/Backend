using System;
using System.Collections.Generic;
using System.Text;

namespace Maestro.Domain.Entities.EDI
{
    public class CarrierFileImportFields : BaseEntity
    {
        public int CarrierFileImportFieldId { get; set; }
        public int CarrierFileId { get; set; }
        public int FieldSequence { get; set; }
        public string FieldName { get; set; }
        public string DataType { get; set; }
        public int MaxWidth { get; set; }
        public int NumericPrecision { get; set; }
        public int NumericScale { get; set; }
        public int isNullable { get; set; }
    }
}
