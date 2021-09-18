using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.IO;

namespace queries
{
    class Program
    {
        static void Main(string[] args)
        {
            var movies = new List<Movie>
            {
                new Movie {Title = "The Dark Knight", Rating = 8.9f, Year = 2008},
                new Movie {Title = "The King's Speech", Rating = 8.0f, Year = 2010},
                new Movie {Title = "Casablanka", Rating = 8.5f, Year = 1942},
                new Movie {Title = "Star Wars V", Rating = 8.7f, Year = 1980}
            };

            var query = movies.Filter(m => m.Year >= 2000);
            foreach (var item in query)
            {
                Console.WriteLine(item.Year);
            }

            var line = new string[1];
            { line[0] = "Hello, world, my, name, is , kitty"; }

            Console.WriteLine(line);
            var line2 = line.ToList();
        }
    }
}
