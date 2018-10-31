using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;

namespace Demo.HttpClients
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test();
            //Test2();
            Test3();
            Console.ReadKey();
        }

        /// <summary>
        /// POST请求
        /// </summary>
        static void Test3()
        {
            var hc = new HttpClient();
            var url = "http://open.drea.cc/chat/get?keyword=hello";

            var paramList = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("keyword","Hello")
            };
            var html = hc.PostAsync(url, new FormUrlEncodedContent(paramList)).Result.Content.ReadAsStringAsync().Result;
            Console.WriteLine(html);
        }

        /// <summary>
        /// Get请求
        /// </summary>
        static void Test2()
        {
            var hc = new HttpClient();
            var url = "http://open.drea.cc/chat/get?keyword=hello";
            var html = hc.GetStringAsync(url).Result;
            Console.WriteLine(html);
        }

        /// <summary>
        /// 读取图片数据写到本地
        /// </summary>
        static void Test()
        {
            //创建Web客户端
            var hc = new HttpClient();
            //读取网络字节流
            var htmlBytes = hc.GetByteArrayAsync("http://drea.cc/template/qu_design/img/logo.png").Result;
            //创建文件流
            var fs = new FileStream("test.jpg", FileMode.Create);
            //将字节流流写入到文件流中
            fs.Write(htmlBytes, 0, htmlBytes.Length);
            fs.Close();
            //读入文件
            var sr = new StreamReader("test.jpg");
            var bs = sr.BaseStream;

            var list = new List<byte>();
            int data;
            while ((data = bs.ReadByte()) != -1)
            {
                list.Add(Convert.ToByte(data));
            }
            var bytes = list.ToArray();
            //创建新文件流
            var newfs = new FileStream("newtest.jpg", FileMode.Create);
            newfs.Write(bytes, 0, bytes.Length);
            newfs.Close();
        }
    }
}
