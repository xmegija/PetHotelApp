using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PetHotelApp.Models;
using PetHotelApp.Data;

namespace PetHotelApp.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=PetHotelDB;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasMany(u => u.Pets).WithOne(p => p.Owner);
            modelBuilder.Entity<Pet>().HasMany(p => p.Reservations).WithOne(r => r.Pet);
            modelBuilder.Entity<Room>().HasMany(r => r.Reservations).WithOne(r => r.Room);
        }
    }
}
