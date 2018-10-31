using System;

namespace Demo.AttributeUsages
{
    [My]
    class Program
    {
        static void Main(string[] args)
        {
            Test();
            Console.ReadKey();
        }

        [My]
        static void Test()
        {
            Console.WriteLine("Hello");
        }
    }
}
