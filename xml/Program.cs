using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace xml
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            //XlmCreate();
            //QueryXml();
            InsertData();
            QueryData();
            

        }

        private static void QueryData()
        {
            var db = new CarDb();

            var query =
                db.Cars.OrderByDescending(d => d.Combined)
                .ThenBy(d => d.Name);
                
            foreach (var item in query.Take(10))
            {
                Console.WriteLine(item.Name + " " + item.Combined);
                
            }

        }

        private static void InsertData()
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<CarDb>());
            var cars = ReadAllFuel("fuel.csv");
            var db = new CarDb();

            if(!db.Cars.Any())
            {
                foreach (var car in cars)
                {
                    db.Cars.Add(car); //doesnt insert data into DB
                }
                db.SaveChanges();
            }
        }

        private static void QueryXml()
        {
            var ns = (XNamespace)"some namespace";
            var ex = (XNamespace)"some different namespace";
            var document = XDocument.Load("fuel.xml");

            var query =
                document.Element(ns + "Cars").Elements(ex + "Car")
                .Where(
                    d => d.Attribute("Manufacturer").Value == "BMW")
                .Select(d=>d.Attribute("Name").Value);
            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
        }

        private static void XlmCreate()
        {

            /*
             * <Cars>
             *      <Car>
             *          <Name>abc</Name>
             *          <Combined>21</Combined>
             *          ...
             *      </Car>
             *      .... more cars
             * </Cars>
             */

            var records = ReadAllFuel("fuel.csv");

            var ns = (XNamespace)"some namespace";
            var ex = (XNamespace)"some different namespace";
            var document = new XDocument();
            var cars = new XElement(ns + "Cars");

            var query =
                records.Select(r => new XElement(ex + "Car",
                    new XAttribute("Name", r.Name),
                    new XAttribute("Combined", r.Combined),
                    new XAttribute("Manufacturer", r.Manufacturer)
                    ));
            cars.Add(query);
            document.Add(cars);
            document.Save("fuel.xml");

            //foreach (var record in records)
            //{
            //    var car = new XElement("Car");
            //    var name = new XElement("Name", record.Name);
            //    var combined = new XElement("Combined", record.Combined);

            //    car.Add(name);
            //    car.Add(combined);
            //    cars.Add(car);
            //}

            //foreach (var record in records)
            //{
            //    var car = new XElement("Car",
            //        new XAttribute("Name", record.Name),
            //        new XAttribute("Combined", record.Combined),
            //        new XAttribute("Manufacturer", record.Manufacturer)
            //        );

            //    cars.Add(car);
            //}



            //==================================================================
            /*
                 * <Cars>
                 *      <Car> Name="abc" Combined "21"></Car>
                 *      .... more cars
                 * </Cars>
                 * 
                 * the same as a previous one but instead of XElement -> XAttribute
            */
        }

        private static List<Car> ReadAllFuel(string path)
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
