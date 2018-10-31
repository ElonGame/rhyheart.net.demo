namespace Demo.Action
{
    public class MyOptions
    {
        public string Url { get; set; }

        public void SetOptions(InnerOptions options)
        {
            Url = options.Url;
        }
    }
}
