using System;
using System.Collections.Generic;

namespace LibraryService.Core.Domain
{
    public class ResourceInstance
    {
        public ResourceInstance()
        {
            Leases = new HashSet<Lease>();
            Resourceinstanceholds = new HashSet<ResourceInstanceHold>();
        }

        public string ResourceCode { get; set; }
        public int EditionId { get; set; }
        public int InstitutionId { get; set; }

        public virtual Edition Edition { get; set; }
        public virtual Institution Institution { get; set; }
        public virtual ICollection<Lease> Leases { get; set; }
        public virtual ICollection<ResourceInstanceHold> Resourceinstanceholds { get; set; }
    }
}
