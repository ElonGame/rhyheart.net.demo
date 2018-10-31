using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Demo.ThreadFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Start");

            var factory = new TaskFactory<DateTime>();
            var tasks = new[]
            {
                factory.StartNew(() =>
                {
                    Process("1");
                    return DateTime.Now.ToUniversalTime();
                }), factory.StartNew(() =>
                {
                    Process("2");
                    return DateTime.Now.ToUniversalTime();
                }), factory.StartNew(() =>
                {
                    Process("3");
                    return DateTime.Now.ToUniversalTime();
                }),
            };

            var sb = new StringBuilder();
            foreach (var task in tasks)
            {
                sb.Append(task.Result+" ");
            }

            Console.WriteLine(sb.ToString());

            Console.WriteLine("Main End");
            Console.ReadKey();
        }

        static void Process(string taskName)
        {
            for (var i = 0; i < 10; i++)
            {
                Thread.Sleep(500);
                var currentThreadId = Thread.CurrentThread.ManagedThreadId;
                Console.WriteLine($"task:{taskName} thread：{currentThreadId} i:{i}");
            }
        }
    }
}
