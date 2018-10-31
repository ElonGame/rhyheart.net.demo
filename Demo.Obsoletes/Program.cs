using System;

namespace Demo.Obsoletes
{
    class Program
    {
        static void Main(string[] args)
        {
            Test();
            //Test2();
            Test3();
            Console.ReadKey();
        }


        [Obsolete("The test mothod is Obsolete", false)]
        static void Test()
        {
            Console.WriteLine("Test Process...");
        }

        [Obsolete("The test2 mothod is Obsolete", true)]
        static void Test2()
        {
            Console.WriteLine("Test2 Process...");
        }

        static void Test3()
        {
            Console.WriteLine("Test3 Process...");
        }
    }
}
