using System;

namespace Demo.Lambdas
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = Operation(Sum);
            Console.WriteLine("Func result is " + result);
            var result2 = Operation((x, y) => x + y);
            Console.WriteLine("Lambda result is " + result2);

            Console.ReadKey();
        }

        static int Operation(Func<int, int, int> func)
        {
            int i = 3;
            int j = 4;
            return func.Invoke(i, j);
        }

        static int Sum(int x, int y)
        {
            return x + y;
        }
    }
}
