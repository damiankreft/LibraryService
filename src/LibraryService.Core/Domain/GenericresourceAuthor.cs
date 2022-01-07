using System;
using System.Collections.Generic;

namespace LibraryService.Core.Domain
{
    public class GenericResourceAuthor
    {
        public int Id { get; set; }
        public int GenericResourceId { get; set; }
        public int AuthorId { get; set; }

        public virtual Author Author { get; set; }
        public virtual GenericResource GenericResource { get; set; }
    }
}
