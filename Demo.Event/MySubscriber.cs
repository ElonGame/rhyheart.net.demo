using System;

namespace Demo.Event
{
    public class MySubscriber
    {
        private string UserId { get; }

        public MySubscriber(string userId)
        {
            UserId = userId;
        }

        public void EventHandler(object sender,MyArgs args)
        {
            Console.WriteLine($"{UserId} {args.Message}");
        }
    }
}
