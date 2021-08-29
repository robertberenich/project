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
            Settings("James", 25, "Spanish");
            Settings("Tom", 36);
        }
        //complete the method
        static void Settings(string name, int age, string language = "English")
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Language: " + language);
        }
    }
}
        /*You are making your own social network application. The users are able to set their names, their ages, and their preferred language.
        If user doesn't set the language, English will be set as default.
        Complete the method with name, age and language parameters and take into account the default English option for language in order to correctly output the information about the provided 2 users.
        */
