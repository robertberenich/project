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
            Dictionary<string, int> metals = new Dictionary<string, int>();
            metals.Add("Platinum", 70);
            metals.Add("Iridium", 20);
            metals.Add("Palladium", 30);
            metals.Add("Scandium", 12);

            string metalName = Console.ReadLine();
            int price = Convert.ToInt32(Console.ReadLine());

            //add 5th metal details to dictionary
            metals.Add(metalName, price);


            int[] prices = metals.Values.ToArray();

            int highestPrice = prices.Max();

            foreach (string i in metals.Keys)
            {
                if (highestPrice == metals[i])
                {
                    Console.WriteLine("The most expensive: " + i);
                    break;
                }
            }

            //your code goes here


        }
    }
}
/*The program you are given defines a metals dictionary, where names are used as keys and their price for 1 gram as values. It takes the name and the price of 5th metal as input.
Add the 5th pair to the dictionary and write code to output the message about the most expensive metal in the dictionary.

Sample Input
Rhodium
225

Sample Output
The most expensive: Rhodium*/
