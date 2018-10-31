using System;

namespace Demo.Event
{
    public class MyPublisher
    {
        public /*event*/ EventHandler<MyArgs> MyEventHandler;

        public void Publish(MyArgs args)
        {
            MyEventHandler?.Invoke(this, args);
        }
    }
}
