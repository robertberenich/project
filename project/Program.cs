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
            HashSet<string> candidates = new HashSet<string>();

            candidates.Add("John");
            candidates.Add("Amelie");
            candidates.Add("Tom");
            candidates.Add("Richard");
            candidates.Add("Barbara");
            candidates.Add("Susan");
            candidates.Add("Charles");
            candidates.Add("Daniel");
            candidates.Add("Tamara");
            candidates.Add("Donald");

            HashSet<string> hiring = new HashSet<string>();

            while (hiring.Count < 3)
            {
                string hire = Console.ReadLine();
                hiring.Add(hire);

            }
            if (hiring.IsSubsetOf(candidates))
            {
                Console.WriteLine("Starting hiring process");
            }
            else Console.WriteLine("Something is wrong");

        }
    }
}
/*We are hiring programmers on our team. There are 10 candidates, and we need to choose 3 of them.
In the program you are given, you have 10 candidates in a hash set. You need to take 3 names as input, add them to a new hiring hash set and check if they are present in our candidates set.
If they are, the program should output "Starting hiring process", otherwise, "Something is wrong".

Sample Input
John
Susan
Daniel

Sample Output
Starting hiring process*/
