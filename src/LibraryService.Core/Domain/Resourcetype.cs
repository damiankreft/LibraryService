using System;
using System.Collections.Generic;

namespace LibraryService.Core.Domain
{
    public class ResourceType
    {
        public ResourceType()
        {
            Genericresources = new HashSet<GenericResource>();
        }

        public int Id { get; set; }
        public string TypeName { get; set; }

        public virtual ICollection<GenericResource> Genericresources { get; set; }
    }
}
