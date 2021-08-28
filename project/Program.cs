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
            int count = Convert.ToInt32(Console.ReadLine());

            int[] numbers = new int[count];

            for (int i = 0; i < count; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Sort(numbers);

            foreach (int k in numbers)
            {
                Console.WriteLine(k);
            }

        }
    }
}
        /*The program you are given takes the N number as the size of an array, followed by N numbers.
        Complete the program to sort and output every element of an array, each on a new line.

        Sample Input
        4
        1
        14
        3
        5

        Sample Output
        1
        3
        5
        14*/