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
            Card card1 = new Card();

            //fix the output
            Console.WriteLine(card1.AccountNum);
        }
    }
    class Card
    {
        private string accountNum = "0011592048120";
        public string AccountNum
        {
            get { return accountNum; }
        }

    }
}
            /*The program you are given should output the account number on the bank card.
            Create a get property to access the corresponding class member*/
        