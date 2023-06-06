using CarPricePrediction.Core.Context;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using System.Text.RegularExpressions;


using (var ctx = new CarsContext())
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
}