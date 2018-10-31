using System;
using System.IO;

namespace Demo.FileStreams
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建文件流
            var fs = new FileStream("text.txt", FileMode.Create, FileAccess.ReadWrite);
            //创建写入器
            var sw = new StreamWriter(fs);
            //写入行
            sw.WriteLine("Hello");
            sw.WriteLine("World");
            //关闭文件流
            sw.Close();
            //关闭写入器
            fs.Close();

            //创建读入器
            var sr = new StreamReader("test.txt");
            string line;
            //读入行
            while ((line = sr.ReadLine())!=null)
            {
                Console.WriteLine(line);
            }
            //关闭读入器
            sr.Close();

            Console.ReadKey();
        }
    }
}
