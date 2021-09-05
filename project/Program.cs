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
            string text = Console.ReadLine();
            int intNum = Convert.ToInt32(Console.ReadLine());
            double doubNum = Convert.ToDouble(Console.ReadLine());


            Printer.Print(text);
            Printer.Print(intNum);
            Printer.Print(doubNum);
        }
    }
    class Printer
    {
        public static void Print<A>(A info)
        {
            Console.WriteLine("Showing " + info);
        }


    }

}
/*You are writing a program that can output the value of a variable of any type. It takes a string, an integer, and a double value as input and then it should output them.
Create a generic method Print for a Printer class to execute the given calls correctly.

Sample Input
Hello
14
7.6

Sample Output
Showing Hello
Showing 14
Showing 7.6*/
