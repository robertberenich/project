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
            string color = Console.ReadLine();
            string equipment = Console.ReadLine();

            Car car = new Car(color, equipment);

            car.GetColor();
            car.GetEquipment();
        }
    }

    public interface IColor
    {
        void GetColor();
    }

    public interface IEquipment
    {
        void GetEquipment();
    }


    public class Car
    {
        public string color;
        public string equipment;

        public Car(string color, string equipment)
        {
            this.color = color;
            this.equipment = equipment;
        }


        public void GetColor()
        {
            Console.WriteLine("Color: " + this.color);
        }

        public void GetEquipment()
        {
            Console.WriteLine("Equipment: " + this.equipment);
        }
    }
}
/*On the car dealership website, you can pre-order a car by specifying its color and equipment.
The program you are given takes the color and the equipment type as input and pass them to constructor of already declared Car class.
Implement IColor and IEquipment interfaces for the Car class and reimplement their GetColor and GetEquipment methods inside it. Each of them should output corresponding message about color/equipment (see sample output).

Sample Input
Blue
Standard

Sample Output
Color: Blue
Equipment: Standard
*/
