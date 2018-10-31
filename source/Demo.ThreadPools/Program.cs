using System;
using System.Threading;

namespace Demo.ThreadPools
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Start");
            //后台线程，主线程执行完便退出程序
            ThreadPool.QueueUserWorkItem(x =>
            {
                Process("test params");
            });
            Console.WriteLine("Main End");
            Console.ReadKey();
        }

        static void Process(object obj)
        {
            Console.WriteLine("Params : " + obj);
            Console.WriteLine("Process Start...");
            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(200);
            }
            Console.WriteLine("Process End...");
            obj = 2;
        }
    }
}
