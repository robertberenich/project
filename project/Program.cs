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
			SortedList<string, int> exam = new SortedList<string, int>();

			exam.Add("Tom", 59);
			exam.Add("Robert", 95);
			exam.Add("Sophie", 72);
			exam.Add("Maria", 68);
			exam.Add("Nick", 84);

			foreach (string item in exam.Keys)
			{
				if (exam[item] < 70)
				{
					Console.WriteLine(item + ":" + " Failed");
				}
				else Console.WriteLine(item + ":" + " Passed");
			}

		}
	}
}
/*There are 5 students in a class, and each needs to score at least 70 points to pass the exam.
The program you are given defines the sorted list and stores the names of the students as keys and the corresponding scores as values.
Complete the program to show the results of the exam.

Explanation
For example, if Tom passed the exam, the program should output "Tom: Passed", and if he didn't, "Tom: Failed".
The result of each student should be output on a new lane.
*/
