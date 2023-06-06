using CarPricePrediction.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPricePrediction.Core.Entities
{
    public class Label : BaseEntity
    {
        public string Name { get; set; }

        public virtual ICollection<Car>? Cars { get; set; }
    }
}
