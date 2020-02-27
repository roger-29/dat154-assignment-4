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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Server=data1.hib.no; Port=5432; Database=h571556;UserId=h571556;Password=pass; Integrated Security = true;");

    }
}

