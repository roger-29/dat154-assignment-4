﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CustomerWebApp
{
    public partial class User
    {
        public User()
        {
            Reservations = new HashSet<Reservation>();
        }

        [Key]
        public int Usernr { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
