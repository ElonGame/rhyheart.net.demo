using System;

namespace Demo.Roche
{
    class Program
    {
        static void Main(string[] args)
        {
            Test1();
            Console.ReadKey();
        }
        
        private static void Test1()
        {
            Console.WriteLine("Test1:");
            var x = 1;
            var y = 12;
            var z = 123;
            Console.WriteLine("x:{0:000}", x);
            Console.WriteLine("y:{0:000}",y);
            Console.WriteLine("z:{0:000}",z);
        }
    }
}
