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
            int amount = Convert.ToInt32(Console.ReadLine());

            int count = 0;
            int totalAmount = 0;
            while (count < amount)
            {
                count++;
                int price = Convert.ToInt32(Console.ReadLine());

                if (!(price % 2 == 0))
                    continue;


                totalAmount += price;
            }
            Console.WriteLine(totalAmount);
        }
    }
}
    /*A store is running a unique promotion. If an item's price is an odd number, the item is free.
    The program takes the number of purchased items as input, followed by the prices of each of the items, then outputs the total amount. 
    Skip the odd prices and exclude them in total amount calculation.

    Sample Input
    3
    140
    235
    100

    Sample Output
    240
    */
