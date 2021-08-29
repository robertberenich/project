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
            int pay = Convert.ToInt32(Console.ReadLine());

            Payment pay1 = new Payment();
            pay1.PaymentValue = pay;
        }
    }

    class Payment
    {
        private int paymentValue;
        public int PaymentValue
        {
            set
            {
                if (value <= 50000)
                {
                    paymentValue = value;
                    Console.WriteLine("Accepted");
                }
                else Console.WriteLine("Error");
            }
        }
    }
}
            /*You are creating our payment application. The maximum payment it can make at one time is 50000.
            The program you are given takes the payment value as input.
            Complete the provided property to take the payment, assign it to appropriate class member, and output "Accepted" if the payment isn't greater than 50000. If it is, the property should output "Error."

            Sample Input
            15000

            Sample Output
            Accepted*/
