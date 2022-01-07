using System;
using System.Collections.Generic;

namespace LibraryService.Core.Domain
{
    public class EditionTranslator
    {
        public int Id { get; set; }
        public int EditionId { get; set; }
        public int TranslatorId { get; set; }

        public virtual Edition Edition { get; set; }
        public virtual Translator Translator { get; set; }
    }
}
