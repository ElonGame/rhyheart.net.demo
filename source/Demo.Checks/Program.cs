using System;

namespace Demo.Checks
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Int32.MaxValue;
            unchecked
            {
                Console.WriteLine(x + 1);//Overflow
            }

            checked
            {
                Console.WriteLine(x + 1);//Exception
            }
        }
    }
}
