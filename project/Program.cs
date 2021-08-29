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
            int num = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                case 1:
                    Console.WriteLine("Sports");
                    break;
                case 2:
                    Console.WriteLine("Politics");
                    break;
                case 3:
                    Console.WriteLine("Business");
                    break;
                case 4:
                    Console.WriteLine("Technology");
                    break;
                case 5:
                    Console.WriteLine("Art");
                    break;
            }

        }
    }
}
    }
}
    /*You are creating a social media application, and need to develop a menu where the user can choose the topic he is interested in learning more about.

    Here are the the topics marked by corresponding numbers:
    1 - Sports
    2 - Politics
    3 - Business
    4 - Technology
    5 - Art

    Write a program to take the number as input and output the corresponding topic name.

    Sample Input
    1

    Sample Output
    Sports
    */
