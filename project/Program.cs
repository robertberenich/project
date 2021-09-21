using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace project
{
    class Program
    {
        public string Name { get; set; }
        public int Id { get; set; }
        static void Main(string[] args)
        {
            Func<int, int> square = x =>
            {
                int temp = x * x + x;
                return temp;
            };
            Console.WriteLine(square(5));



            Parametr[] developers = new Parametr[3];
            for (int i = 0; i < 3; i++)
            {
                developers[i] = new Parametr();
            }
            developers[0].Name= "Scott";
            developers[1].Name = "Alex";
            developers[2].Name = "John";

            foreach (var employee in developers.OrderBy(e => e.Name))
            {
                Console.WriteLine(employee.Name);
            }

            foreach (var employee in developers.Where(StartsWithS))
            {

            }

            int[,] arr = new int[3, 5] { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 } };
            var count = 0;
            var smt = arr.GetLength(1);
            for (int i = 0; i <arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    count = count + arr[i, j];
                }
                
            }
            Console.WriteLine(count);
        }

        private static bool StartsWithS(Parametr employee)
        {
            return employee.Name.StartsWith("S");
        }
    }
    class Parametr
    {
        public string Name { get; set; }
        public int Id { get; set; }
    }
}   
