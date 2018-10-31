using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Action
{
    public class MyPublisher
    {
        public void Publish(Action<MyArgs> myAction)
        {
            var args = new MyArgs {Message = "Start"};
            myAction.Invoke(args);
            Console.WriteLine(args.Message);

            args.Message = "Process";
            myAction(args);
            Console.WriteLine(args.Message);

            args.Message = "End";
            myAction.Invoke(args);
            Console.WriteLine(args.Message);

        }
    }
}

