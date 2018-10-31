using System;
using System.IO;

namespace Demo.Directories
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("当前目录...");
            var currentDirectory = Directory.GetCurrentDirectory();
            Console.WriteLine("CurrentDirectory：" + currentDirectory);
            Console.WriteLine("创建目录...");
            var direcotryInfo = Directory.CreateDirectory("test");
            Console.WriteLine("目录是否存在...");
            var exists = Directory.Exists("test");
            Console.WriteLine("Exists："+exists);
            var creationTime = Directory.GetCreationTime("test");
            Console.WriteLine("CreationTime：" + creationTime);
            Console.WriteLine("移除目录...");
            Directory.Delete("test");
            exists = Directory.Exists("test");
            Console.WriteLine("Exists："+exists);


            Console.ReadKey();
        }
    }
}
