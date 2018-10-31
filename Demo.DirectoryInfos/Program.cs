using System;
using System.IO;
using System.Linq;

namespace Demo.DirectoryInfos
{
    class Program
    {
        static void Main(string[] args)
        {
            var directoryInfo = new DirectoryInfo(Directory.GetCurrentDirectory());
            Console.WriteLine("Name:"+ directoryInfo.Name);
            Console.WriteLine("Exists:" + directoryInfo.Exists);
            Console.WriteLine("Root:" + directoryInfo.Root);
            Console.WriteLine("Parent:" + directoryInfo.Parent);
            Console.WriteLine("Extension:" + directoryInfo.Extension);
            Console.WriteLine("FullName:" + directoryInfo.FullName);
            Console.WriteLine("Files：");
            directoryInfo.GetFiles().Select(x=>x.Name).ToList().ForEach(Console.WriteLine);
            Console.ReadKey();
        }
    }
}
