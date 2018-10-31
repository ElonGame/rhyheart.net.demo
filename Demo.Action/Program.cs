using System;

namespace Demo.Action
{
    class Program
    {
        static void Main(string[] args)
        {
            Init(options =>
            {
                options.Url = "http://drea.cc";
            });

            Init(options =>
            {
                options.SetOptions(new InnerOptions { Url = "http://open.drea.cc" });
            });

            Process(Notice);

            Console.ReadKey();
        }

        static void Init(Action<MyOptions> action)
        {
            var options = new MyOptions();
            action(options);
            //action.Invoke(options);
            Console.WriteLine($"get option url is {options.Url}");
        }

        static void Process(Action<MyArgs> action)
        {
            action(new MyArgs { Message = "Start" });
            action(new MyArgs { Message = "Process" });
            action(new MyArgs { Message = "End" });
        }

        static void Notice(MyArgs args)
        {
            Console.WriteLine(args.Message);
        }

    }
}
