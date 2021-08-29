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
            int day1Winner = Convert.ToInt32(Console.ReadLine());
            int day2Winner = Convert.ToInt32(Console.ReadLine());
            int day3Winner = Convert.ToInt32(Console.ReadLine());

            int[] sum = new int[3];
            sum[0] = day1Winner;
            sum[1] = day2Winner;
            sum[2] = day3Winner;

            string[][] olympiad = new string[][]
            {
                //day 1 - 5 participants
                new string[] { "Jill Yan", "Bridgette Ramona", "Sree Sanda", "Jareth Charlene", "Carl Soner" },
                //day 2 - 7 participants
                new string[] { "Anna Hel", "Mariette Vedrana", "Fran Mayur", "Drake Hilmar", "Nikolay Brooks", "Eliana Vlatko", "Villem Mario" },
                //day 3 - 4 participants
                new string[] { "Hieremias Zavia", "Ziya Ollie", "Christoffel Casper", "Kristian Dana", }

            };
            //your code goes here
            for (int i = 0; i < 3; i++)
            {
                int winner = sum[i] - 1;
                Console.WriteLine(olympiad[i][winner]);
            }
        }
    }
}
        /*The qualifiers for the Olympiad lasts 3 days, and one winner is selected each qualifying day.
        The jagged array you are given represents the list of all participants, divided by the number of days
        Write a program to take the numbers of each day's winners as input and output them.

        Sample Input
        2
        3
        4

        Sample Output
        Bridgette Ramona
        Fran Mayur
        Kristian Dana*/