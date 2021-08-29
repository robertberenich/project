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
            int salaryBudget = Convert.ToInt32(Console.ReadLine());
            int percent = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Before the increase: " + salaryBudget);

            //complete the method call
            Increase(ref salaryBudget, percent);

            Console.WriteLine("After the increase: " + salaryBudget);
        }
        static void Increase(ref int x, double y)
        {
            x = Convert.ToInt32(x + (y / 100 * x));

        }
    }
}
        /*Management has decided to increase the total salary budget.
        The program you are given takes the current salary budget and the raise percentage as input. It should output the salary budget before the increase, then calculate and output the budget with the raises included.
        Fix the program by completing the Increase() method (which should calculate the new salary budget) and calling it, so that the provided outputs work correctly.

        Sample Input
        150000
        15

        Sample Output
        Before the increase: 150000
        After the increase: 172500*/
