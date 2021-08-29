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
            int N = Convert.ToInt32(Console.ReadLine());

            while (true)
            {
                int res = Convert.ToInt32(Console.ReadLine());
                if (res > N)
                {
                    Console.WriteLine("Sold: {0}", res);
                    break;
                }

            }
        }
    }
}
    /*We are making a program for auction with a maximum bid set. The count of bids is variable.
    Write a program to take the maximum bid as input, then take all bids from auction participants until the maximum bid is exceeded.
    The program should output the corresponding message with the winning bid.

    Sample Input
    1600
    800
    1300
    1700

    Sample Output
    Sold: 1700
    */
