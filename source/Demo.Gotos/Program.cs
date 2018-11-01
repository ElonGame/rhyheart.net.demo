using System;

namespace Demo.Gotos
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = 0;
            goto check;
            loop:
            Console.Write(i++ + " ");
            check:
            if (i < 10)
                goto loop;

            Console.ReadKey();
        }
    }
}
