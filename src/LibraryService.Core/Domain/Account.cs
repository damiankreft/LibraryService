using System.Collections.Generic;

namespace LibraryService.Core.Domain
{
    public class Account
    {
        public int Id { get; set; }
        public string Lastname { get; set; }
        public string Firstname { get; set; }
        public string Email { get; set; }
        public uint? LeaseCounter { get; set; }
        public float? Rating { get; set; }
        public string Salt { get; set; }
        public string Password { get; set; }

        public virtual Librarian Librarian { get; set; }
        public virtual ICollection<Lease> Leases { get; set; }

        public Account()
        {
            Leases = new HashSet<Lease>();
        }

        public Account(string lastname, string firstname, string email, string passwordHash, string salt)
        {
            Lastname = lastname;
            Firstname = firstname;
            Email = email;
            Salt = salt;
            Password = passwordHash;
        }
    }
}
