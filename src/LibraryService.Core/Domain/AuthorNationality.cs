using System;
using System.Collections.Generic;

namespace LibraryService.Core.Domain
{
    public class AuthorNationality
    {
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public int NationalityId { get; set; }

        public virtual Author Author { get; set; }
        public virtual Nationality Nationality { get; set; }
    }
}
