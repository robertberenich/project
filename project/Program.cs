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
            int numOfDeps = Convert.ToInt32(Console.ReadLine());

            int count = 0;
            while (count < numOfDeps)
            {
                string depName = Console.ReadLine();
                Department dep = new Department(depName);
                count++;
            }

            Console.WriteLine("Number of departments: " + Department.depCount);
        }
    }
    class Department
    {

        public string depName;
        
        public static int depCount = 2;
        

        //complete the constructor
        public Department(string name)
        {
            Console.WriteLine("Department opened: " + name);
            this.depName = name;
            depCount++;
        }
    }

    /*A company has 2 departments and it is growing, so more departments are needed.
    The program you are given takes the number of departments to be opened as input, then takes their names and creates Department objects, passing their names as the constructor.
    Complete the Department class to have 1 static member depCount with an initial value of 2 for the number of departments and the constructor that will count it and output corresponding message(see sample output).

    Sample Input
    2
    Finance
    Marketing

    Sample Output
    Department opened: Finance
    Department opened: Marketing
    Number of departments: 4*/
}