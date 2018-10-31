using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Demo.Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test1();
            //Test2();
            //Test3();
            //Test4();
            //Test5();
            //Test6();
            //Test7();
            Test8();
        }

        /// <summary>
        /// 返回值
        /// </summary>
        static void Test8()
        {
            Console.WriteLine("Main Start");
            var task = new Task<string>(() =>
            {
                Process();
                return "这是task1执行结果";
            });
            var task2 = new Task<string>(() =>
            {
                Process();
                return "这是task2执行结果";
            });
            task.Start();
            task2.Start();
            Console.WriteLine(task.Result);
            Console.WriteLine(task2.Result);
            Console.WriteLine("Main End");
            Console.ReadKey();
        }
        
        //无等待
        static void Test1()
        {
            Console.WriteLine("Test1...");
            Console.WriteLine("Main Start");
            var task = new Task(Process);
            var task2 = new Task(Process);
            task.Start();
            task2.Start();
            Console.WriteLine("Main End");
            Console.ReadKey();
        }

        //等待执行结束
        static void Test2()
        {
            Console.WriteLine("\n\nTest2...");
            Console.WriteLine("Main Start");
            var task = new Task(Process);
            var task2 = new Task(Process);
            task.Start();
            task2.Start();
            task.Wait();
            task2.Wait();
            Console.WriteLine("Main End");
            Console.ReadKey();
        }

        //等待执行1ms
        static void Test3()
        {
            Console.WriteLine("\n\nTest3...");
            Console.WriteLine("Main Start");
            var task = new Task(Process);
            var task2 = new Task(Process);
            task.Start();
            task2.Start();
            task.Wait(1);
            task2.Wait(1);
            Console.WriteLine("Main End");
            Console.ReadKey();
        }

        //任务取消标记
        static void Test4()
        {
            Console.WriteLine("Main Start");
            var cts = new CancellationTokenSource();
            Task.Factory.StartNew(x =>
            {
                Console.WriteLine("Process Start...");
                for (var i = 0; i < 10; i++)
                {
                    if (!cts.Token.IsCancellationRequested)
                    {
                        Thread.Sleep(200);
                        Console.Write(i + " ");
                    }
                }
                Console.WriteLine();
                Console.WriteLine("Process End...");

            }, cts.Token, cts.Token);

            for (var i = 0; i < 10; i++)
            {
                Thread.Sleep(200);
                if (i == 5)
                {
                    cts.Cancel();
                    Console.WriteLine("Task Cancel");
                }
            }
            Console.WriteLine("Main End");
            Console.ReadKey();
        }

        //任务异常
        static void Test5()
        {
            var cts = new CancellationTokenSource();
            try
            {
                Task.Factory.StartNew(Process,cts.Token);
                Console.WriteLine("当前标记：" + cts.IsCancellationRequested);
                for (var i = 0; i < 10; i++)
                {
                    Thread.Sleep(200);
                    if (i == 5)
                    {
                        throw new Exception("哈哈哈，出异常了");
                    }
                }
            }
            catch (Exception e)
            {
                cts.Cancel();
                Console.WriteLine(e.Message);
                Console.WriteLine("当前标记：" + cts.IsCancellationRequested);
            }

            Console.ReadKey();
        }

        /// <summary>
        /// 普通任务
        /// </summary>
        static void Test6()
        {
            Console.WriteLine("\n\nTest6...");
            Console.WriteLine("Main Start");
            var sb = new StringBuilder();
            var task = new Task(() =>
            {
                new Task(() =>
                {
                    Thread.Sleep(200);
                    sb.Append("任务1 ");
                }).Start();

                new Task(() =>
                {
                    Thread.Sleep(200);
                    sb.Append("任务2 ");
                }).Start();

                new Task(() =>
                {
                    Thread.Sleep(200);
                    sb.Append("任务3 ");
                }).Start();

            });

            task.Start();
            task.Wait();
            Console.WriteLine(sb.ToString());
            Console.WriteLine("Main End");
            Console.ReadKey();
        }

        /// <summary>
        /// 父子任务
        /// </summary>
        static void Test7()
        {
            Console.WriteLine("\n\nTest7...");
            Console.WriteLine("Main Start");
            var sb = new StringBuilder();
            var task = new Task(() =>
            {
                new Task(() =>
                {
                    Thread.Sleep(200);
                    sb.Append("任务1 ");
                },TaskCreationOptions.AttachedToParent).Start();

                new Task(() =>
                {
                    Thread.Sleep(200);
                    sb.Append("任务2 ");
                },TaskCreationOptions.AttachedToParent).Start();

                new Task(() =>
                {
                    Thread.Sleep(200);
                    sb.Append("任务3 ");
                },TaskCreationOptions.AttachedToParent).Start();

            });

            task.Start();
            task.Wait();
            Console.WriteLine(sb.ToString());
            Console.WriteLine("Main End");
            Console.ReadKey();
        }

        static void Process()
        {
            Console.WriteLine("Process Start...");
            for (var i = 0; i < 10; i++)
            {
                Thread.Sleep(200);
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Process End...");
        }
    }
}
