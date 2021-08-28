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
            string password = Console.ReadLine();
            char[] notAllowedSymbols = { '!', '#', '$', '%', '&', '(', ')', '*', ',', '+', '-' };
            int num = notAllowedSymbols.Length;
            bool test = false;
            for (int i = 0; i < password.Length; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    if (password.Contains(notAllowedSymbols[j]))
                    {
                        Console.WriteLine("Invalid");
                        test = true;
                        break;
                    }

                }
                if (test == true) break;
            }

            /*You are creating an authentication system.
The password shouldn't contain any of these symbols:
char[] notAllowedSymbols = { '!', '#', '$', '%', '&', '(', ')', '*', ',', '+', '-' };
            The given program takes the password as input.

            Task
Write a program to output "Invalid", if it contains any disallowed symbols.
If the password requirement is satisfied, program shouldn't output anything.

Sample Input
yl1893!dm$

Sample Output
Invalid*/

        }
    }
}