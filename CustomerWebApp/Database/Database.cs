using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CustomerWebApp.Database
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Rooms> Rooms { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Reservations> Reservations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Host=data1.hib.no;Database=h180312;Username=h180312;Password=pass");
    }
}

