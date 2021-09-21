using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq
{
    public class CarStatistics
    {
        public CarStatistics()
        {
            Min = Int32.MaxValue;
            Max = Int32.MinValue;
        }
        public CarStatistics Accumulate(Car car)
        {
            Total += car.Combined;
            Count += 1;

            Max = Math.Max(Max, car.Combined);
            Min = Math.Min(Max, car.Combined);
            

            return this;
        }
        public int Max { get; set; }
        public int Min { get; set; }
        public int Total { get; set; }
        public int Count { get; set; }
        public double Average { get; set; }

        public CarStatistics Compute()
        {
            Average = Total / Count;
            return this;
        }
    }
}
