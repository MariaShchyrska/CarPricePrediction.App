using CsvHelper;
using CsvHelper.Configuration;
using CarPricePrediction.ParserApp.Dtos;
using System.Globalization;
using CarPricePrediction.Core.Context;
using CarPricePrediction.Core.Entities;
using System.Text.RegularExpressions;

Console.WriteLine($"{DateTime.Now.ToString("HH:mm:ss")} -- APP STARTED --");

using (var ctx = new CarsContext())
{
    ctx.Database.EnsureDeleted();
    ctx.Database.EnsureCreated();

    using (var reader = new StreamReader("Quikr_car.csv"))
    using (var csvReader = new CsvReader(reader, CultureInfo.InvariantCulture))
    {
        var records = csvReader.GetRecords<CarReadDto>().ToList();
        int row = 0;

        List<string> labels = new List<string>();
        List<string> locations = new List<string>();
        List<string> fuel_types = new List<string>();
        List<string> companies = new List<string>();

        /*foreach (var r in records)
        {
            if (!string.IsNullOrEmpty(r.Label))
                labels.Add(r.Label);
            if (!string.IsNullOrEmpty(r.Location))
                locations.Add(r.Location);
            if (!string.IsNullOrEmpty(r.Fuel_type))
                fuel_types.Add(r.Fuel_type);
            if (!string.IsNullOrEmpty(r.Company))
                companies.Add(r.Company);
        }

        ctx.Labels.AddRange(labels.Distinct().Select(x => new Label
        {
            Name = x
        }));
        ctx.Locations.AddRange(locations.Distinct().Select(x => new Location
        {
            Name = x
        }));
        ctx.Fuel_Types.AddRange(fuel_types.Distinct().Select(x => new Fuel_type
        {
            Name = x
        }));
        ctx.Companies.AddRange(companies.Distinct().Select(x => new Company
        {
            Name = x
        })); */

        ctx.SaveChanges();
        Console.WriteLine($"{DateTime.Now.ToString("HH:mm:ss")} -- LABELS, LOCATIONS, FUEL_TYPES AND COMPANIES ADDED --");

        var cars = new List<Car>();

        foreach (var x in records)
        {
            var car = new Car
            {
                Name = x.Name,
                Price = ParseNumberString(x.Price),
                Kms_driven = ParseNumberString(x.Kms_driven),
                Owner = StringfIsEmpty(x.Owner),
                Year = x.Year,
            };

            car.Owner = !string.IsNullOrEmpty(x.Owner) ? x.Owner : string.Empty;

            car.Company = ctx.Companies.FirstOrDefault(pt => pt.Name == x.Company);
            if (car.Company == null)
            {
                car.Company = new Company { Name = x.Company };
                ctx.Companies.Add(car.Company);
            }

            car.Fuel_Type = ctx.Fuel_Types.FirstOrDefault(pt => pt.Name == x.Fuel_type);
            if (car.Fuel_Type == null)
            {
                car.Fuel_Type = new Fuel_type { Name = x.Fuel_type };
                ctx.Fuel_Types.Add(car.Fuel_Type);
            }

            car.Label = ctx.Labels.FirstOrDefault(pt => pt.Name == x.Label);
            if (car.Label == null)
            {
                car.Label = new Label { Name = x.Label };
                ctx.Labels.Add(car.Label);
            }

            car.Location = ctx.Locations.FirstOrDefault(pt => pt.Name == x.Location);
            if (car.Location == null)
            {
                car.Location = new Location { Name = x.Location };
                ctx.Locations.Add(car.Location);
            }

            cars.Add(car);
        }

        ctx.Cars.AddRange(cars);
        ctx.SaveChanges();
        Console.WriteLine($"{DateTime.Now.ToString("HH:mm:ss")} -- CARS ADDED --");
    }
}

static double ParseNumberString(string numberString)
{
    if (string.IsNullOrEmpty(numberString)) return 0;
    double num = 0;
    if (!double.TryParse(numberString, NumberStyles.AllowThousands | NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out num))
    {
        numberString = numberString.ToUpper().Trim();
        numberString = Regex.Replace(numberString, @"[^\d.,]", "");
        double.TryParse(numberString, NumberStyles.AllowThousands | NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out num);
    }

    return num;
}

static string StringfIsEmpty(string emptystring)
{
    if (string.IsNullOrEmpty(emptystring))
        return string.Empty;

    return emptystring;
}
