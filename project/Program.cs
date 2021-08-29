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
            Project project = new Project();

        }
    }
    class Project
    {
        public Project()
        {
            Console.WriteLine("Project created");
        }

    }
}
    /*Your graphic application needs to report that a new project has been created successfully once the "Create" button has been pressed.
    Complete the class by adding a constructor that will show message "Project created" once the operation is done.*/
