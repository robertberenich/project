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
            Console.WriteLine(Add(10, 12));
            Console.WriteLine(Add(1.5, 2.9));
        }
        //complete the method to sum
        static int Add(int x, int y)
        {
            return x + y;
        }
        //overload it for double type
        static double Add(double x, double y)
        {
            return x + y;
        }
    }
}
    /*Complete the Add() method so that it will calculate the sum of two numbers given as arguments.
    Overload it in order to do the same operation with double type values.*/
