using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CustomerWebApp
{
    public partial class Users
    {
        public Users()
        {
            Reservations = new HashSet<Reservations>();
        }

        [Key]
        public int Usernr { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Reservations> Reservations { get; set; }
    }
}
