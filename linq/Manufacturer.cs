using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq
{
    public class Manufacturer
    {
        public string Name { get; set; }
        public string Headquarters { get; set; }
        public int Year{ get; set; }

        internal static Manufacturer processInfo(string line)
        {
            var separatedLine = line.Split(',');

            return new Manufacturer
            {
                Name = separatedLine[0],
                Headquarters = separatedLine[1],
                Year = int.Parse(separatedLine[2])
            };
        }
    }
}
