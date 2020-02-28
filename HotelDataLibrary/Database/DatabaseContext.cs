using System;

using Microsoft.EntityFrameworkCore;

using HotelDataLibrary.Models;
using HotelDataLibrary.Migrations;

namespace HotelDataLibrary.Database {
    public class DatabaseContext : DbContext {


        public DbSet<Room> Rooms { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            // modelBuilder.Seed();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Server=data1.hib.no; Port=5432; Database=h571556;UserId=h571556;Password=pass; Integrated Security = true;");

    }
}
