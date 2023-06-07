using CarPricePrediction.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPricePrediction.Core.Entities
{
    public class Car : BaseEntity
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public double Kms_driven { get; set; }
        public string Owner { get; set; }
        public int Year { get; set; }
        public Guid? CompanyId { get; set; }
        public virtual Company? Company { get; set; }

        public Guid? Fuel_TypeId { get; set; }
        public virtual Fuel_type? Fuel_Type { get; set; }

        public Guid? LabelId { get; set; }
        public virtual Label? Label { get; set; }

        public Guid? LocationId { get; set; }
        public virtual Location? Location { get; set; }
    }

    /*public class Car : INamedEntity<Guid>
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string Label { get; set; }
        public string Location { get; set; }
        public double Price { get; set; }
        public double Kms_driven { get; set; }
        public string Fuel_type { get; set; }
        public string Owner { get; set; }
        public int Year { get; set; }
        public string Company { get; set; }

        public virtual ICollection<Company> Companies { get; set; } = new HashSet<Company>();
        public virtual ICollection<Fuel_type> Fuel_Types { get; set; } = new HashSet<Fuel_type>();
        public virtual ICollection<Label> Labels { get; set; } = new HashSet<Label>();
        public virtual ICollection<Location> Locations { get; set; } = new HashSet<Location>();

    } */
}