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
            Unit unit1 = new Unit();
            Unit musketeer = new Musketeer();
            Unit magician = new Magician();

            unit1.Attack();
            musketeer.Attack();
            magician.Attack();
        }
    }

    class Unit
    {
        public virtual void Attack()
        {
            Console.WriteLine("Using sword!");
        }
    }
    class Musketeer: Unit
    {
        public override void Attack()
        {
            Console.WriteLine("Using musket!");
        }
    }
    class Magician: Unit
    {
        public override void Attack()
        {
            Console.WriteLine("Using magic!");
        }
    }
}
    /*In a turn-based strategy game, each unit can attack.
    The standard unit attacks with a sword. But there are two more types of units - musketeers and magicians, who attack in their own way.
    The program you are given declares Unit class which has a method Attack(). It outputs "Using sword!".
    Derive Musketeer and Magician classes from the Unit class and override its Attack() method to output the corresponding messages while attacking:
    Musketeer => "Using musket!"
    Magician => "Using magic!"*/
