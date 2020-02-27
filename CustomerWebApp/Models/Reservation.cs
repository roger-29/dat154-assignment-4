﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CustomerWebApp
{
    public partial class Reservation
    {
        [Key]
        public int Id { get; set; }
        public int? Roomnr { get; set; }
        public int? Usernr { get; set; }

        public virtual Room RoomnrNavigation { get; set; }
        public virtual User UsernrNavigation { get; set; }
    }
}
