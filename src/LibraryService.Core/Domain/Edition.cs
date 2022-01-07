using System;
using System.Collections.Generic;

namespace LibraryService.Core.Domain
{
    public class Edition
    {
        public Edition()
        {
            EditionTranslators = new HashSet<EditionTranslator>();
            Editionholds = new HashSet<EditionHold>();
            Resourceinstances = new HashSet<ResourceInstance>();
        }

        public int Id { get; set; }
        public int GenericResourceId { get; set; }
        public decimal? Recompense { get; set; }
        public bool? Leaseable { get; set; }
        public string Isbn13 { get; set; }
        public short? DatePublished { get; set; }

        public virtual GenericResource GenericResource { get; set; }
        public virtual ICollection<EditionTranslator> EditionTranslators { get; set; }
        public virtual ICollection<EditionHold> Editionholds { get; set; }
        public virtual ICollection<ResourceInstance> Resourceinstances { get; set; }
    }
}
