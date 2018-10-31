using System;
using System.Diagnostics;

namespace Demo.Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            Test();
            Console.ReadKey();
        }

        //Debug模式下才会执行
        [Conditional("DEBUG")]
        static void Test()
        {
            Console.WriteLine("Debug Success");
        }
    }
}
