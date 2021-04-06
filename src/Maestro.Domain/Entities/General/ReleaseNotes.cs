using System;
using System.Collections.Generic;
using System.Text;

namespace Maestro.Domain.Entities.General
{
    public class ReleaseNotes : BaseEntity
    {
        public int ReleaseNoteId { get; set; }
        public string ReleaseNoteDescription { get; set; }
        public string ChangeLogs { get; set; }
        public DateTime DeploymentDate { get; set; }
        public bool IsHotfix { get; set; }
        public int IsClientFacing { get; set; }
        public int MyProperty { get; set; }
    }
}
