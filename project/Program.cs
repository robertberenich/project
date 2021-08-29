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
            int[,] num = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            for (int j = 0; j < 3; j++)
            {
                for (int k = 0; k < 3; k++)
                {
                    Console.Write(num[j, k]);
                }
                Console.WriteLine();
            }

        }
    }
}
        /*Complete the program to output this array int[,] num = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };  in the form of a table (without separation):
        123
        456
        789*/