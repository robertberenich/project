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
            string name = Console.ReadLine();

            if (name.Length>10)
            {
                name = name.Remove(10);
            }

            Console.WriteLine(name);
            //your code goes here

            /*In the RPG game you are playing, the name of the player - character should not exceed 10 characters in length.
            Write a program to take the player - character as input, and abbreviate it beginning at the 10th character if the name is longer than 10 characters.Output the final result.

            Sample Input
            DragonBorn126

            Sample Output
            DragonBorn*/
        }
    }
}