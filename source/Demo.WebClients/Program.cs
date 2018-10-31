using System;
using System.Net;

namespace Demo.WebClients
{
    class Program
    {
        static void Main(string[] args)
        {
            var wc = new WebClient();
            var url = "http://open.drea.cc/chat/get?keyword=hello";
            var html = wc.DownloadString(url);
            Console.WriteLine(html);
            wc.DownloadFile(url,"test.txt");
            wc.DownloadFile("http://drea.cc/template/qu_design/img/logo.png", "test.jpg");
            Console.ReadKey();
        }
    }
}
