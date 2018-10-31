namespace Demo.Delegate
{
    public class MyPublisher
    {
        public delegate void MyEvent(MyArgs args);
        public MyEvent MyEventHandler { get; set; }

        public void Publish(MyArgs args)
        {
            MyEventHandler?.Invoke(args);
        }

    }
}
