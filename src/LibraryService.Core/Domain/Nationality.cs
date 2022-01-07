using System;
using System.Collections.Generic;

namespace LibraryService.Core.Domain
{
    public class Nationality
    {
        public Nationality()
        {
            AuthorNationalities = new HashSet<AuthorNationality>();
        }

        public int Id { get; set; }
        public string Country { get; set; }

        public virtual ICollection<AuthorNationality> AuthorNationalities { get; set; }
    }
}
