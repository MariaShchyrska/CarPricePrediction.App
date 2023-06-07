using CarPricePrediction.Core.Context;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using System.Text.RegularExpressions;
using CarPricePrediction.Repositories;
using CarPricePrediction.Core.Entities;
using System;
using System.Linq;


/*using (var ctx = new CarsContext())
{
    var top10 = ctx.Cars.Include(x => x.Location).Include(x => x.Label).Include(x => x.Fuel_Type).Include(x => x.Company).Take(10).ToList();

    foreach (var c in top10)
    {
        Console.WriteLine($"\t{c.Name}");
        Console.WriteLine($"---LABEL: \t{c.Label.Name}");
        Console.WriteLine($"---LOCATION: \t{ c.Location.Name}");
        Console.WriteLine($"---PRICE: \t{ParseNumberString(c.Price.ToString()):N0}");
        Console.WriteLine($"---KMS DRIVEN: {ParseNumberString(c.Kms_driven.ToString()):N0}");
        Console.WriteLine($"---FUEL TYPE: {c.Fuel_Type.Name}");
        Console.WriteLine($"---OWNER/S: {StringfIsEmpty(c.Owner)}");
        Console.WriteLine($"---YEAR: \t{c.Year}");
        Console.WriteLine($"---COMPANY: \t{c.Company.Name}");
        Console.WriteLine("---------------------------------------------------------");
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
        return "This car has no owner";

    return emptystring;
}*/

var repository = new Repository<Car, Guid>(new CarsContext());
var newCarName = "A new car 2023";

// Перевірка наявності машини з таким же іменем
var existingCar = repository.GetAll().FirstOrDefault(c => c.Name == newCarName);
if (existingCar != null)
{
    Console.WriteLine("A car with the same name already exists.");
}
else
{
    repository.Create(new Car
    {
        Name = newCarName,
        CompanyId = Guid.Parse("C5AE8E9C-E7E3-4D97-A3C9-2E13F9CE5EA4"),
        Fuel_TypeId = Guid.Parse("91C29E8E-EDD3-4FA1-95A1-63EFA32D3441"),
        LabelId = Guid.Parse("A7739F95-4549-430E-9BC2-1F2257765082"),
        LocationId = Guid.Parse("9406D3BB-EA3C-461F-8570-9029DFB948D9"),
        Owner = "1",
    });

    Console.WriteLine(repository.GetAll().Count());

    foreach (var car in repository.GetAll().OrderBy(x => x.Name))
    {
        Console.WriteLine($"Car: {car.Name}");
    }

    var newCar = repository.GetAll().FirstOrDefault(c => c.Name == newCarName);
    if (newCar != null)
    {
        repository.Delete(newCar);
        Console.WriteLine("New car has been deleted.");
        Console.WriteLine(repository.GetAll().Count());
    }
    else
    {
        Console.WriteLine("New car not found.");
    }
}