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
            string[] words = {
                "home",
                "programming",
                "victory",
                "C#",
                "football",
                "sport",
                "book",
                "learn",
                "dream",
                "fun"
            };

            string letter = Console.ReadLine();

            int count = 0;
            foreach (string i in words)
            {
                if (i.Contains(letter))
                {
                    Console.WriteLine(i);
                    count++;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("No match");
            }
            //your code goes here

            /*The program you are given defines an array with 10 words and takes a letter as input.
            Write a program to iterate through the array and output words containing the taken letter.
            If there is no such word, the program should output "No match".

            Sample Input
            u

            Sample Output
            fun*/
        }
    }
}