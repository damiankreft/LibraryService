using System;
using System.Collections.Generic;

namespace LibraryService.Core.Domain
{
    public class Librarian
    {
        public Librarian()
        {
            Leases = new HashSet<Lease>();
        }

        public int AccountId { get; set; }
        public sbyte AccessLevel { get; set; }

        public virtual Account Account { get; set; }
        public virtual ICollection<Lease> Leases { get; set; }
    }
}
