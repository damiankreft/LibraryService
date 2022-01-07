using System;
using System.Collections.Generic;

namespace LibraryService.Core.Domain
{
    public class GenericResource
    {
        public GenericResource()
        {
            Editions = new HashSet<Edition>();
            GenericresourceAuthors = new HashSet<GenericResourceAuthor>();
            Genericresourceholds = new HashSet<GenericResourceHold>();
        }

        public int Id { get; set; }
        public int ResourceType { get; set; }
        public string GenericResourceName { get; set; }

        public virtual ResourceType ResourceTypeNavigation { get; set; }
        public virtual ICollection<Edition> Editions { get; set; }
        public virtual ICollection<GenericResourceAuthor> GenericresourceAuthors { get; set; }
        public virtual ICollection<GenericResourceHold> Genericresourceholds { get; set; }
    }
}
