using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CustomerWebApp
{
    public partial class Reservations
    {
        [Key]
        public int Id { get; set; }
        public int? Roomnr { get; set; }
        public int? Usernr { get; set; }

        public virtual Rooms RoomnrNavigation { get; set; }
        public virtual Users UsernrNavigation { get; set; }
    }
}
