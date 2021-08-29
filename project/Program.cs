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
            string accNumber = Console.ReadLine();
            double balance = Convert.ToDouble(Console.ReadLine());

            User user = new User(accNumber, balance);

            user.ShowDetails();

        }
    }

    class Account
    {
        protected double Balance { get; set; }
    }

    class User : Account
    {
        public string AccNumber { get; set; }

        //complete the constructor
        public User(string accNumber, double balance)
        {
            this.AccNumber = accNumber;
            this.Balance = balance;
        }

        public void ShowDetails()
        {
            Console.WriteLine("Account N: " + AccNumber);
            Console.WriteLine("Balance: " + Balance);
        }
    }
}
    /*
    The program you are given takes an account number and its balance as input.
    It defines Account class with 1 member balance and derives User class from it with 1 additional member - the account number, then creates a user object and tries to store the balance and account number in it, and shows the details. But something is wrong.
    Fix the program so that it completes the User() constructor, which should assign the parameters to the corresponding members of the User class.
    Also, check the access modifier of balance member of Account class.

    Sample Input
    005615216
    1488.36

    Sample Output
    Account N: 005615216
    Balance: 1488.36
    */
