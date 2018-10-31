using System;
using System.Threading;

namespace Demo.Threads
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Start");
            //前台线程，主程序执行完后，等待子线程执行完才退出程序
            new Thread(Process).Start();
            Console.WriteLine("Main End");
        }

        static void Process()
        {
            Console.WriteLine("Process Start...");
            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(200);
            }
            Console.WriteLine("Process End...");
            Console.ReadKey();
        }
    }
}
