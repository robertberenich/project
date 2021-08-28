using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace project
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = Convert.ToDouble(Console.ReadLine());
            double num2 = Convert.ToDouble(Console.ReadLine());

            Avg avg = new Avg(num1, num2);

            Console.WriteLine(avg.GetAvg());
        }
    }

    class Avg
    {
        double num1;
        double num2;

        public Avg(double num1, double num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }

        public double GetAvg()
        {
            return (num1 + num2) / 2;
        }
    }
}
        /*The program you are given takes 2 numbers as input and should calculate and output their average. But something is wrong.
        Complete the Avg class by creating the constructor, where the 2 parameters will be assigned to members of the class.

        Sample Input
        5.0
        4.0

        Sample Output
        4.5*/