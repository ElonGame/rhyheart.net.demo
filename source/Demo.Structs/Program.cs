using System;

namespace Demo.Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            var cp = new ClassPoint(1, 2);
            var cp2 = cp;
            Console.WriteLine($"前cs2.x:{cp.X}");
            cp.X = 11;
            Console.WriteLine($"后cs2.X:{cp2.X}");

            var sp = new StructPoint(1, 2);
            var sp2 = sp;
            Console.WriteLine($"前sp2.x:{sp2.X}");
            sp.X = 11;
            Console.WriteLine($"后sp2.x:{sp2.X}");

            Console.ReadKey();
        }
    }
}
