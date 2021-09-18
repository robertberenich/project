using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace linq
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



            wut[] developers = new wut[3];
            for (int i = 0; i < 3; i++)
            {
                developers[i] = new wut();
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
        }

        private static bool StartsWithS(wut employee)
        {
            return employee.Name.StartsWith("S");
        }
    }
    class wut
    {
        public string Name { get; set; }
        public int Id { get; set; }
    }
}   
