using System;

namespace Demo.Delegate
{
    public class MySubscriber
    {
        private string UserId { get; }
        public MySubscriber(string userId)
        {
            UserId = userId;
        }

        public void EventHandler(MyArgs args)
        {
            Console.WriteLine($"{UserId} {args.Message}");
        }

    }
}
