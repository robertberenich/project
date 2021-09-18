using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace query
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

            var cars = ProcessFile("fuel.csv");

            var cars2 = ProcessFile2("fuel.csv");

            var query =
                cars.Where(c => c.Manufacturer == "Audi")
                .OrderByDescending(c => c.Combined)
                .ThenBy(c => c.Name)
                .Select(c => c)
                .First();

            
            var query2 =
                from car in cars
                orderby car.Combined descending, car.Name ascending
                select car;

            var query3 =
                cars.Where(c=>c.Manufacturer == "Audi")
                .Select(c => c.Name)
                .Take(1);

            Console.WriteLine();

            var query4 =
                cars.Where(c => c.Manufacturer == "Audi")
                .SelectMany(c => c.Name)
                .OrderBy(c => c);

            //foreach (var name in query3)
            //{
            //    Console.WriteLine(name);
            //}

            //foreach (var item in query3)
            //{
            //    foreach (var character in item)
            //    {
            //        Console.Write(character + " ");
            //    }
            //}
            //foreach (var item in query2)
            //{
            //    Console.WriteLine($"{item.Name}: {item.Combined}");
            //}

            //foreach (var item in cars)
            //{
            //    Console.WriteLine(item.Name);
            //}
            //var request = char.parse(console.readline());
            //var count = 0;
            //foreach (var character in query4)
            //{
            //    if (character == request)
            //    {
            //        console.writeline(character);
            //        count++;
            //    }
                
            //}
            //console.writeline($"there is {count} \'{request}\' characters");
        }

        private static List<Car> ProcessFile2(string path)
        {
            var query =
            from line in File.ReadAllLines(path).Skip(1)
            where (line.Length > 0)
            select Car.ProcessData(line);
            
            return query.ToList(); 
        }

        private static List<Car> ProcessFile(string path)
        {
            return
            File.ReadAllLines(path)
                .Skip(1)
                .Where(line => line.Length > 0)
                .Select(Car.ProcessData)
                .ToList();

        }
    }
}
