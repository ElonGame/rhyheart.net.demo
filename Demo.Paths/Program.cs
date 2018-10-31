using System;
using System.IO;

namespace Demo.Paths
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = Directory.GetCurrentDirectory();
            Console.WriteLine("GetDirectoryName:" + Path.GetDirectoryName(path));
            Console.WriteLine("GetExtension:" + Path.GetExtension(path));
            Console.WriteLine("GetFileName:" + Path.GetFileName(path));
            Console.WriteLine("GetPathRoot:" + Path.GetPathRoot(path));
            Console.ReadKey();
        }
    }
}
