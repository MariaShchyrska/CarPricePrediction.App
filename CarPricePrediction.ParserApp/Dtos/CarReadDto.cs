using CsvHelper.Configuration.Attributes;
using CsvHelper.Configuration;
using CsvHelper.TypeConversion;
using System.Globalization;

namespace CarPricePrediction.ParserApp.Dtos
{
    public class CarReadDto
    {
        [Name("Name")]
        public string Name { get; set; }

        [Name("Label")]
        public string? Label { get; set; }

        [Name("Location")]
        public string? Location { get; set; }

        [Index(4)]
        [Name("Price")]
        public string? Price { get; set; }

        [Index(5)]
        [Name("Kms_driven")]
        public string? Kms_driven { get; set; }

        [Name("Fuel_type")]
        public string? Fuel_type { get; set; }

        [Name("Owner")]
        public string? Owner { get; set; }

        [Index(8)]
        [Name("Year")]
        public int Year { get; set; }

        [Name("Company")]
        public string? Company { get; set; }
    }
}
