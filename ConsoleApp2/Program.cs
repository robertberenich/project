using System;
using System.Collections;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        private static string h = "Hello world";
        public IEnumerable GetCharacters()
        { 
            foreach(var c in h)
            {
                yield return c;
            }

        }


        //public IQueryable  GetCharacters2()
        //{
        //    foreach (var c in h)
        //    {
        //        yield return c;
        //    }
        //}

        static void Main(string[] args)
        {
            var t = h.Where(c => c == 'l');

            var t = h.Where(c => c == 'l').ToList();

            Console.WriteLine("Hello World!");
        }
    }
}
