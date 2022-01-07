using System;
using System.Collections.Generic;

namespace LibraryService.Core.Domain
{
    public class EditionHold
    {
        public int Id { get; set; }
        public int EditionId { get; set; }
        public DateTime ResourceReservationDate { get; set; }

        public virtual Edition Edition { get; set; }
    }
}
