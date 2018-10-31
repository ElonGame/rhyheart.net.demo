using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection.Metadata;
using System.Threading;
using System.Threading.Tasks;

namespace Demo.Parallels
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Start\n");
            //Test1();
            //Test2();
            Test();
            Console.WriteLine("\nMain End");
            Console.ReadKey();
        }

        static void Test()
        {
            Console.WriteLine("准备数据中...");
            var list = new List<int>();
            for (var i = 0; i < 100; i++)
            {
                list.Add(i);
            }
            Console.WriteLine("准备数据完成\n");

            var sw1 = new Stopwatch();
            sw1.Start();
            var count1 = 0;
            for (var i = 0; i < list.Count; i++)
            {
                Thread.Sleep(10);
                count1 += i;
            }
            sw1.Stop();
            Console.WriteLine($"一般for循环总耗时：{sw1.ElapsedMilliseconds} 结果：{count1}");

            var sw2 = new Stopwatch();
            sw2.Start();
            var count2 = 0;
            foreach (var i in list)
            {
                Thread.Sleep(10);
                count2 += i;
            }
            sw2.Stop();
            Console.WriteLine($"一般foreach循环总耗时：{sw2.ElapsedMilliseconds} 结果：{count2}");

            var sw3 = new Stopwatch();
            sw3.Start();
            var count3 = 0;
            Parallel.For(0,list.Count, i =>
            {
                Thread.Sleep(10);
                count3 += i;
            });
            sw3.Stop();
            Console.WriteLine($"并行for循环总耗时：{sw3.ElapsedMilliseconds} 结果：{count3}");

            var sw4 = new Stopwatch();
            sw4.Start();
            var count4 = 0;
            Parallel.ForEach(list,i =>
            {
                Thread.Sleep(10);
                count4 += i;
            });
            sw4.Stop();
            Console.WriteLine($"并行foreach循环总耗时：{sw4.ElapsedMilliseconds} 结果：{count4}");

        }


        static void Test1()
        {
            Console.WriteLine("Test1...");

            Parallel.For(0, 10, x =>
            {
                Thread.Sleep(200);
                var tid = Thread.CurrentThread.ManagedThreadId;
                Console.WriteLine($"tid:{tid} x:{x}");
            });
        }

        static void Test2()
        {
            Console.WriteLine("\n\nTest2...");
            var list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Parallel.ForEach(list, x =>
            {
                Thread.Sleep(200);
                var tid = Thread.CurrentThread.ManagedThreadId;
                Console.WriteLine($"tid:{tid} x:{x}");
            });
        }
    }
}
