using CarPricePrediction.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPricePrediction.Core.Context
{
    public class CarsContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Fuel_type> Fuel_Types { get; set; }
        public DbSet<Label> Labels { get; set; }
        public DbSet<Location> Locations { get; set; }

        /*public DbSet<Car> Cars => Set<Car>();
        public DbSet<Company> Companies => Set<Company>();
        public DbSet<Fuel_type> Fuel_Types => Set<Fuel_type>();
        public DbSet<Label> Labels => Set<Label>();
        public DbSet<Location> Locations => Set<Location>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Location>().HasData(
                new Location { Name = "Ahmedabad" },
                new Location { Name = "Anand" },
                new Location { Name = "Bangalore" },
                new Location { Name = "Bhubaneswar" },
                new Location { Name = "Bilaspur" },
                new Location { Name = "BoplpurSantiniketan" },
                new Location { Name = "Chandigarh" },
                new Location { Name = "Chennai" },
                new Location { Name = "Coimbatore" },
                new Location { Name = "Delhi" },
                new Location { Name = "Dhanbad" },
                new Location { Name = "Dwarka" },
                new Location { Name = "Faridabad" },
                new Location { Name = "GirSomnath" },
                new Location { Name = "Gurgaon" },
                new Location { Name = "Hyderabad" },
                new Location { Name = "Jagdalpur" },
                new Location { Name = "Laipur" },
                new Location { Name = "Kanchipuram" },
                new Location { Name = "Kochi" },
                new Location { Name = "Kolkata" },
                new Location { Name = "Kozhikode" },
                new Location { Name = "Kurnool" },
                new Location { Name = "Lucknow" },
                new Location { Name = "Madurai" },
                new Location { Name = "Mahasamund" },
                new Location { Name = "Malappuram" },
                new Location { Name = "Mumbai" },
                new Location { Name = "Muzaffarnagar" },
                new Location { Name = "Nagpur" },
                new Location { Name = "Nanded" },
                new Location { Name = "NaviMumbai" },
                new Location { Name = "Pondicherry" },
                new Location { Name = "Pune" },
                new Location { Name = "Surat" },
                new Location { Name = "Thane" },
                new Location { Name = "Trichy" },
                new Location { Name = "Udaipur" },
                new Location { Name = "Uttarpara" }
                );

            modelBuilder.Entity<Car>()
            .HasMany(x => x.Locations)
            .WithMany(x => x.Cars);
        }
        */

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=USER-PC\SQLEXPRESS;Database=CarDb_v1;Trusted_Connection=True;TrustServerCertificate=True;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
