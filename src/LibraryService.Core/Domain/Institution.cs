using System;
using System.Collections.Generic;

namespace LibraryService.Core.Domain
{
    public class Institution
    {
        public Institution()
        {
            Resourceinstances = new HashSet<ResourceInstance>();
        }

        public int Id { get; set; }
        public string InstitutionName { get; set; }

        public virtual ICollection<ResourceInstance> Resourceinstances { get; set; }
    }
}
