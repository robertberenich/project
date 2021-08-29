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
            int[] numbers = new int[5];
            int count = 0;
            int res = 0;
            while (count < 5)
            {
                numbers[count] = Convert.ToInt32(Console.ReadLine());
                count++;
            }
            //your code goes here
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    res = res + numbers[i];
                }

            }

            Console.WriteLine(res);
        }
    }
}
            /*The program you are given takes 5 numbers as input and stores them in an array.
            Complete the program to go through the array and output the the sum of even numbers.

            Sample Input
            10
            890
            15
            3699
            14

            Sample Output
            914*/