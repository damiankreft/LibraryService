using System;
using System.Collections.Generic;

namespace LibraryService.Core.Domain
{
    public class GenericResourceHold
    {
        public int Id { get; set; }
        public int GenericResourceId { get; set; }
        public DateTime ResourceReservationDate { get; set; }

        public virtual GenericResource GenericResource { get; set; }
    }
}
