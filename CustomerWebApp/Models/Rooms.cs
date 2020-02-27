using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CustomerWebApp
{
    public partial class Rooms
    {
        public Rooms()
        {
            Reservations = new HashSet<Reservations>();
        }

        [Key]
        public int Roomnr { get; set; }
        public int Numberofbeds { get; set; }
        public int Roomsize { get; set; }
        public int Price { get; set; }
        public bool Available { get; set; }

        public virtual ICollection<Reservations> Reservations { get; set; }
    }
}
