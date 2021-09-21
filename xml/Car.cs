using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xml
{
    public class Car
    {
        public int Id { get; set; }
        public int Year { get; set; }
        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public double Displacement { get; set; }
        public int Cylinders{ get; set; }
        public int City { get; set; }
        public int Highway { get; set; }
        public int Combined{ get; set; }

        internal static Car ProcessData(string line)
        {
            var separatedLine = line.Split(',');
            return new Car
            {
                Year = int.Parse(separatedLine[0]),
                Manufacturer = separatedLine[1],
                Name = separatedLine[2],
                Displacement = double.Parse(separatedLine[3]),
                Cylinders = int.Parse(separatedLine[4]),
                City = int.Parse(separatedLine[5]),
                Highway = int.Parse(separatedLine[6]),
                Combined = int.Parse(separatedLine[7])
            };
        }
    }
}
