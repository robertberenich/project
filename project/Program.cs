﻿using System;
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
            double discount = Convert.ToInt32(Console.ReadLine());

            Dictionary<string, int> coffee = new Dictionary<string, int>();
            coffee.Add("Americano", 50);
            coffee.Add("Latte", 70);
            coffee.Add("Flat White", 60);
            coffee.Add("Espresso", 60);
            coffee.Add("Cappuccino", 80);
            coffee.Add("Mocha", 90);

            string[] s = coffee.Keys.ToArray();
            foreach (string i in s)
            {
                double num = coffee[i];
                double res = num - (num * (discount / 100));
                coffee[i] = (int)Math.Ceiling(res);
            }
            foreach (string item in coffee.Keys)
            {
                Console.WriteLine(item + ": " + coffee[item]);
            }
        }
    }
}
/*A coffee shop manager is running a promotion and wants to offer a discount for coffee drinks.
The program you are given takes the discount value as input and defines a dictionary, where the names of the coffee drinks are set as keys, and their prices are set as values.
Write a program to discount all of the prices and output a new price list in the format shown below.

Sample Input
10

Sample Output
Americano: 45
Latte: 63
Flat White: 54
Espresso: 54
Cappuccino: 72
Mocha: 81*/