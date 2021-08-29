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
            string name = Console.ReadLine();
            string phoneNumber = Console.ReadLine();

            User user1 = new User(name, phoneNumber);
            user1.ShowDetails();
        }
    }
    class User
    {
        private string userName;
        private string phoneNumber;
        //complete the constructor
        public User(string x, string y)
        {
            userName = x;
            phoneNumber = y;
            Console.WriteLine("Profile is created");
        }
        public void ShowDetails()
        {
            Console.WriteLine("Name: " + userName);
            Console.WriteLine("Phone number: " + phoneNumber);
        }
    }
}
    /*We are creating an application for mobile operator.
    The user need to enter his/her name and phone number to register.
    The program you are given should take this data as input, use them in constructor while creating the object, and output the corresponding message.

    Sample Input
    Tom
    00412561

    Sample Output
    Profile is created
    Name: Tom
    Phone number: 00412561*/
