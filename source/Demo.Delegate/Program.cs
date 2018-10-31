using System;

namespace Demo.Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            var publish = new MyPublisher();
            publish.MyEventHandler += new MySubscriber("001").EventHandler;
            publish.MyEventHandler += new MySubscriber("002").EventHandler;
            publish.MyEventHandler += new MySubscriber("003").EventHandler;
            publish.Publish(new MyArgs { Message = "Hello" });
            Console.ReadKey();
        }
    }
}
