using System;

namespace LibraryService.Core.Model
{
    public class Lease
    {
        public uint Id { get; set; }
        public Resource Resource { get; set; }
        public DateTime LeaseStart { get; set; }
        public TimeSpan LeaseDuration { get; set; }


        // getLeaseEndDate()

        
    }
}