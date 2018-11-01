using System;
using System.Collections.Generic;

namespace Demo.Yields
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = YieldDemo();
            foreach (var i in list)
            {
                Console.Write(i + " ");
            }

            Console.ReadKey();
        }

        static IEnumerable<int> YieldDemo()
        {
            for (var i = 0; i < 10; i++)
            {
                yield return i;
            }
        }
      
    }
}
