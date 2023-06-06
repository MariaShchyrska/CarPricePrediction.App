/*using CarPricePrediction.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPricePrediction.Core.Context
{
    public static class CarsContextSeedExtension
    {
        public static void SeedLabels(this ModelBuilder builder)
        {
            builder.Entity<Car>()
                .HasMany(x => x.Labels)
                .WithMany(x => x.Cars);

            builder.Entity<Car>()
                .HasMany(x => x.Fuel_Types)
                .WithMany(x => x.Cars);

            builder.Entity<Car>()
                .HasMany(x => x.Companies)
                .WithMany(x => x.Cars);

            /*builder.Entity<Label>().HasData(
                new Label { Name = "GOLD" },
                new Label { Name = "PLATINUM" }
                );*/

            /*builder.Entity<Fuel_type>().HasData(
                new Fuel_type { Name = "CNG" },
                new Fuel_type { Name = "Diesel" },
                new Fuel_type { Name = "Electric" },
                new Fuel_type { Name = "Hybrid" },
                new Fuel_type { Name = "LPG" },
                new Fuel_type { Name = "Petrol" },
                new Fuel_type { Name = "Petrol + CNG" }
                );
        }
    }
}
*/
