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
            string name1 = Console.ReadLine();
            int points1 = Convert.ToInt32(Console.ReadLine());
            string name2 = Console.ReadLine();
            int points2 = Convert.ToInt32(Console.ReadLine());

            DancerPoints dancer1 = new DancerPoints(name1, points1);
            DancerPoints dancer2 = new DancerPoints(name2, points2);

            DancerPoints total = dancer1 + dancer2;
            Console.WriteLine(total.name);
            Console.WriteLine(total.points);
        }
    }

    class DancerPoints
    {
        public string name;
        public int points;
        public DancerPoints(string name, int points)
        {
            this.name = name;
            this.points = points;
        }

        public static DancerPoints operator + (DancerPoints dancer1, DancerPoints dancer2)
        {
            string nameLocal = $"{dancer1.name} & {dancer2.name}";
            int pointsLocal = dancer1.points + dancer2.points;
            DancerPoints duo = new DancerPoints(nameLocal, pointsLocal);
            return duo;
        }

    }
}
    /*In a ballroom dancing competition, each dancer from a pair is evaluated separately, and then their points are summed up to get the total pair score.
    The program you are given takes the names and the points of each dancer as input and creates a DancerPoints objects for each dancer, using the taken name and score values as parameters for constructors.
    Complete the given class, using overload + operator to return an new object where the names of dancers are in one string (see sample output) and the score is equal to the sum of their points.

    Sample Input
    Dave
    8
    Jessica
    7

    Sample Output
    Dave & Jessica
    15*/