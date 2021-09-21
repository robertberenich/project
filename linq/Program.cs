using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace linq
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            var manufacturers = ReadAllInfo("manufacturers.csv");
            var cars = ReadAllfuel("fuel.csv");

            var queryCars =
                manufacturers.Where(c => c.Headquarters == "Japan")
                .Select(c => c);

            var queryFuel =
                cars.Where(c => c.Manufacturer == "Audi")
                .OrderByDescending(c => c.Combined)
                .ThenBy(c => c.Name)
                .Select(c => new
                {
                    c.Combined,
                    c.Name,
                    c.Manufacturer
                });
            var queryJoinExtensionMethod =
                cars.Join(manufacturers,
                c=>c.Manufacturer,
                m=>m.Name,
                (c,m) => new
                {
                    c.Combined,
                    c.Name,
                    m.Headquarters
                })
                .OrderByDescending(c => c.Combined)
                .ThenBy(c => c.Name);

            var queryDouleJoinExtensionMethod =
                cars.Join(manufacturers,
                c => new { c.Manufacturer, c.Year},
                m => new { Manufacturer = m.Name, m.Year},
                (c, m) => new
                {
                    c.Combined,
                    c.Name,
                    m.Headquarters
                })
                .OrderByDescending(c => c.Combined)
                .ThenBy(c => c.Name);

            //foreach (var item in queryJoinExtensionMethod.Take(10))
            //{
            //    Console.WriteLine($"{item.Name}: {item.Headquarters}, {item.Combined}");
            //}

            //var queryJoinTest =
            //    from car in cars
            //    join manufacturer in manufacturers
            //        on car.Manufacturer equals manufacturer.Name
            //    orderby car.Combined descending, car.Name
            //    select new
            //    {
            //        manufacturer.Headquarters,
            //        car.Name,
            //        car.Manufacturer
            //    };

            //foreach (var item in queryCars)
            //{
            //    Console.WriteLine(item.Headquarters);
            //}

            //foreach (var item in queryFuel)
            //{
            //    Console.WriteLine($"{item.Name}: {item.Combined}, {item.Manufacturer}");
            //}

            //foreach (var item in queryJoinTest.Take(10))
            //{
            //    Console.WriteLine($"{item.Name}: {item.Headquarters}, {item.Manufacturer}");
            //}

            //==========================================================================================================================================================================================================================================================

            var queryGroup =
                cars.GroupBy(c => c.Manufacturer.ToUpper())
                .OrderBy(g => g.Key);

            var queryJoingGroup =
                manufacturers.GroupJoin(cars,
                m => m.Name,
                c => c.Manufacturer, (m, g) =>
                new
                {
                    Manufacturer = m,
                    Cars = g
                })
                .OrderBy(m => m.Manufacturer.Name);

            var queryMaxMinAvg =
                cars.GroupBy(c => c.Manufacturer)
                .Select(grouped =>
                {
                    var result = grouped.Aggregate(new CarStatistics(),
                                            (acc, grouped) => acc.Accumulate(grouped),
                                            (acc) => acc.Compute());
                    return new
                    {
                        Name = grouped.Key,
                        Avg = result.Average,
                        Max = result.Max,
                        Min = result.Min

                    };
                })
                .OrderByDescending(res => res.Max);
            foreach (var item in queryMaxMinAvg)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine($"\tMax: {item.Max}");
                Console.WriteLine($"\tMin: {item.Min}");
                Console.WriteLine($"\tAvg: {item.Avg}");
            }

            //foreach (var item in queryJoingGroup)
            //{
            //    Console.WriteLine(item.Manufacturer.Headquarters);
            //    foreach (var i2 in item.Cars.OrderByDescending(c => c.Combined).Take(2))
            //    {
            //        Console.WriteLine(i2.Name);
            //    }
            //}

            //foreach (var item in queryGroup)
            //{
            //    Console.WriteLine(item.Key);
            //    foreach (var car in item.OrderByDescending(c => c.Combined).Take(2))
            //    {
            //        Console.WriteLine($"\t{car.Name} : {car.Combined}");
            //    }
            //}


        }

        private static List<Car> ReadAllfuel(string path)
        {
            return
                File.ReadAllLines(path)
                .Skip(1)
                .Where(line => line.Length > 0)
                .Select(Car.ProcessData)
                .ToList();
        }

        private static List<Manufacturer> ReadAllInfo(string path)
        {
            return
                File.ReadAllLines(path)
                .Skip(1)
                .Where(line => line.Length > 0)
                .Select(Manufacturer.processInfo)
                .ToList();
        }

        
    }
}
