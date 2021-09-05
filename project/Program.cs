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
            int hi1 = 5;
            string hi2 = "Robert";

            hi2.hiExtension();
            hi1.hiExtension();
            Console.WriteLine("==================================");
            //vs instance method
            TestClass hi1TestClass = new TestClass();
            TestClass hi2TestClass = new TestClass();
            hi1TestClass.hiInstanceMethod(hi1);
            hi2TestClass.hiInstanceMethod(hi2);
            Console.WriteLine("==================================");
            //vs static method
            TestClassStatic.hiStaticMethod(hi1);
            TestClassStatic.hiStaticMethod(hi2);
            Console.WriteLine("==================================");

        }

    }
    public static class ExtentionTest
    {
        public static void hiExtension<T>(this T a)
        {
            Console.WriteLine("Extension Hi " + a);
        }
    }

    public class TestClass
    {
        public void hiInstanceMethod<T>(T a)
        {
            Console.WriteLine("Instance method hi " + a);
        }
    }
    public static class TestClassStatic
    {
        public static void hiStaticMethod<T>(T a)
        {
            Console.WriteLine("Static method hi " + a);
        }
    }
}
