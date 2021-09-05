using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace linq
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\windows";


            jobMethod2(path);
            //jobMethod(path);


        }

        private static void jobMethod2(string path)
        {
            var query = new DirectoryInfo(path).GetFiles()
                .OrderByDescending(f => f.Length)
                .Take(5);
            foreach (var file in query)
            {
                Console.WriteLine($"{file.Name}: {file.Length}");
            }
        }

        private static void jobMethod(string path)
        {
            DirectoryInfo directory = new DirectoryInfo(path);
            FileInfo[] files = directory.GetFiles();
            Array.Sort(files, new CompareTool());

            for (int i = 0; i < 5; i++)
            {
                FileInfo sample = files[i];
                Console.WriteLine($"{sample.Name}: {sample.Length}");
            }
        }
    }
    public class CompareTool : IComparer<FileInfo>
    {
        public int Compare(FileInfo x, FileInfo y)
        {
            return y.Length.CompareTo(x.Length);
        }
    }
}
