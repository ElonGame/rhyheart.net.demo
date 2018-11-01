using System;
using Demo.PrivateProtecteds;
using Demo.ProtectedInternals;

namespace Demo.OtherAssemblies
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstClass fc = new FirstClass();
            SecondClass sc = new SecondClass();

            TestFirstClass tfc = new TestFirstClass();
            TestSecondClass tsc = new TestSecondClass();


            Console.WriteLine("Hello World!");
        }
    }
}
