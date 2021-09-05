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
            int length = Convert.ToInt32(Console.ReadLine());
            int width = Convert.ToInt32(Console.ReadLine());
            int height = Convert.ToInt32(Console.ReadLine());

            Cuboid cuboid = new Cuboid(length, width, height);

            Console.WriteLine("Volume: " + cuboid.Volume());
            Console.WriteLine("Perimeter: " + cuboid.Perimeter());
        }
    }
    struct Cuboid
    {
        public int length;
        public int width;
        public int height;

        public Cuboid(int x, int y, int z)
        {
            length = x;
            width = y;
            height = z;
        }


        public int Volume()
        {
            int volume = this.height * this.length * this.width;
            return volume;
        }

        public int Perimeter()
        {
            int perimeter = 4 * (this.height + this.length + this.width);
            return perimeter;
        }
    }
}
/*A cuboid is a three-dimensional shape with a length, width, and a height.
The program you are given takes takes those dimensions as inputs, defines Cuboid struct and creates its object.
Complete the program by creating a constructor, which will take the length, the width, and the height as parameters and assign them to its struct members.
Also complete Volume() and Perimeter() methods inside the struct, to calculate and return them, so that the given methods calls work correctly.

Sample Input
5
4
5
*/
