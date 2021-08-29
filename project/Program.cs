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
            int totalPrice = Convert.ToInt32(Console.ReadLine());

            double answer = Discount(totalPrice);

            Console.WriteLine(answer);


        }
        //complete the method declaration
        static double Discount(int x)
        {
            double result = x;
            if (x >= 10000)
            {
                result = x - (x * 0.2);
            }
            return result;
            //complete the method body

        }
    }
}
    /*A store is running a promotion: if the total purchase price is equal to or exceeds
    10000, the price will be discounted by 20%.
    The program you are given takes the total purchase price as input.
    Complete the given method to take the total purchase price as an argument, and calculate and return the discounted price if campaign's requirement is satisfied.
    The method should return the same price if discount is not given.

    Sample Input
    13000

    Sample Output
    10400
    */
