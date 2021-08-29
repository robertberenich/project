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
            string[] games = { "Alien Shooter", "Tic Tac Toe", "Snake", "Puzzle", "Football" };

            //your code goes here

            int input = Convert.ToInt32(Console.ReadLine());
            if (input < 5 && !(input > 5))
            {
                Console.WriteLine(games[input]);
            }
            else Console.WriteLine("Invalid number");
        }
    }
}
        /*A game machine has 5 games installed on it string[] games = { "Alien Shooter", "Tic Tac Toe", "Snake", "Puzzle", "Football" };  
         Write a program to take N number as input and output the corresponding game with N index from the array.
        If user enters an invalid number that is out of array range, the program should output "Invalid number".

        Sample Input
        3

        Sample Output
        Puzzle*/