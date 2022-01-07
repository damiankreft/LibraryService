using System;
using System.Collections.Generic;

namespace LibraryService.Core.Domain
{
    public class ResourceInstanceHold
    {
        public int Id { get; set; }
        public string ResourceInstanceId { get; set; }
        public DateTime ResourceReservationDate { get; set; }

        public virtual ResourceInstance ResourceInstance { get; set; }
    }
}
