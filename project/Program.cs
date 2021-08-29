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
            int[] array = new int[5];
            for (int i = 0; i < 5; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            int max = array.Max();
            int min = array.Min();
            Console.WriteLine(max + min);
        }
    }
}
            /*Write a program to take 5 numbers as input, then calculate and output the sum of the maximum and the minimum inputted values.

            Sample Input
            5
            6
            14
            2
            1

            Sample Output
            15*/