using System;

namespace Demo.ProtectedInternals
{
    class Program
    {
        static void Main(string[] args)
        {
            SecondClass sc = new SecondClass();
            SecondClass.InnerSecondClass isc = new SecondClass.InnerSecondClass();
        }
    }
}
