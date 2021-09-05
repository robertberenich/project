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
            Queue<int> q = new Queue<int>();

            while (q.Count < 3)
            {
                int num = Convert.ToInt32(Console.ReadLine());
                q.Enqueue(num);
            }

            Console.Write("Queue: ");
            foreach (int i in q)
                Console.Write(i + " ");

            Console.WriteLine();

            int[] newArr = q.ToArray();
            Array.Sort(newArr);

            Console.Write("Sorted: ");
            foreach (int item in newArr)
            {
                Console.Write(item + " ");
            }

            //your code goes here

        }
    }
}
/*Queue


Write a program that will take 3 numbers as input and store them in a defined queue.
Also, add code to output the sorted sequence of elements in the queue, separated by a space.

Sample Input
6
3
14

Sample Output
Queue: 6 3 14
Sorted: 3 6 14*/
