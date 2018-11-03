using System;
using System.Collections.Generic;

namespace Demo.Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            var demo = new Demo<int>(new List<int> { 0, 1, 2, 3, 4, 5 });
            demo.Changed += (obj, arg) =>
            {
                Console.WriteLine("改变咯，" + arg.Message);
            };
            Console.WriteLine(demo[2]);
            demo[2] = 22;
            Console.WriteLine(demo[2]);
            Console.ReadKey();
        }
    }
}
