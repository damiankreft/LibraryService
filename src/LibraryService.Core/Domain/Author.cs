using System;
using System.Collections.Generic;

namespace LibraryService.Core.Domain
{
    public class Author
    {
        public Author()
        {
            AuthorNationalities = new HashSet<AuthorNationality>();
            GenericresourceAuthors = new HashSet<GenericResourceAuthor>();
        }

        public int Id { get; set; }
        public string Fullname { get; set; }

        public virtual ICollection<AuthorNationality> AuthorNationalities { get; set; }
        public virtual ICollection<GenericResourceAuthor> GenericresourceAuthors { get; set; }
    }
}
