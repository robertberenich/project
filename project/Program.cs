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
            string[] tours = { "England", "Spain", "Italy", "Portugal", "France" };
            int choice = Convert.ToInt32(Console.ReadLine());
            try
            {
                Console.WriteLine($"{tours[choice]}");
            }
            catch
            {
                Console.WriteLine("Wrong number");
            }
            finally
            {
                Console.WriteLine("Goodbye");
            }

        }
    }

}
/*A tour operator offers package holidays in England, Spain, Italy, Portugal and France.
The program you are given defines an array with those options and takes N number as input.
Write a program to output the package option with N index. If the number is out of range, program should output "Wrong number". Regardless of the option results, the program should output "Goodbye" at the end.

Sample Input
2

Sample Output
Italy
Goodbye
*/
