using System;
using System.IO;
using System.Net;
using System.Text;

namespace Demo.HttpWebRequests
{
    class Program
    {
        static void Main(string[] args)
        {
            Test();
            Console.ReadKey();
        }

        static void Test2()
        {
            var request = (HttpWebRequest)WebRequest.Create("http://open.drea.cc/chat/get?keyword=hello");
            request.Method = "post";
           /* request.ContentType = "application/json";
            var postStr = "{\"keyword\":\"hello\"}";
            var bytes = Encoding.Default.GetBytes(postStr);
            request.ContentLength = bytes.Length;
            var rqs = request.GetRequestStream();
            rqs.Write(bytes,0,bytes.Length);
            rqs.Close();*/

            var response = (HttpWebResponse)request.GetResponse();
            var rps = response.GetResponseStream();
            if (rps != null)
            {
                var sr = new StreamReader(rps);
                var html = sr.ReadToEnd();
                Console.WriteLine(html);
            }
            else
            {
                Console.WriteLine("获取数据失败");
            }
        }

        static void Test()
        {
            var request = (HttpWebRequest)WebRequest.Create("http://open.drea.cc/chat/get?keyword=hello");
            request.Method = "get";
            var response = (HttpWebResponse)request.GetResponse();
            using (var rs = response.GetResponseStream())
            {
                if (rs != null)
                {
                    using (var sr = new StreamReader(rs))
                    {
                        var html = sr.ReadToEnd();
                        Console.WriteLine(html);
                    }
                }
                else
                {
                    Console.WriteLine("获取数据失败");
                }

            }
            Console.ReadKey();
        }
    }
}
