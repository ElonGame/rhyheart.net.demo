using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace Demo.Func
{
    class Program
    {
        static void Main(string[] args)
        {
            Init(() => new MyOptions { Url = "http://drea.cc" });
            Process(x => new MyArgs { Message = x });

            Console.ReadKey();
        }

        static void Init(Func<MyOptions> func)
        {
            var options = func();
            Console.WriteLine($"my options url is {options.Url}");
        }

        static void Process(Func<string, MyArgs> func)
        {
            var result = func("hello");
            Console.WriteLine(JsonConvert.SerializeObject(result));
        }

    }
}
