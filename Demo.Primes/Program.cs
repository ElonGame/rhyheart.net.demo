using System;
using System.Collections.Generic;

namespace Demo.Primes
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 1000;
            var list = GetPrimeList(number);
            Console.WriteLine(number + "以内的素数：");
            var sum = 0;
            foreach (var i in list)
            {
                sum += i;
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"总共有{list.Count}个，之和为：{sum}");
            Console.ReadKey();
        }

        static List<int> GetPrimeList(int number)
        {
            var list = new List<int>();
            for (var i = 2; i < number; i++)
            {
                var isPrime = true;
                for (var j = 2; j < i; j++)
                {
                    if (i % j == 0)
                        isPrime = false;
                }

                if (isPrime)
                    list.Add(i);
            }

            return list;
        }

    }
}
