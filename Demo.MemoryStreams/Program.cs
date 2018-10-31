using System;
using System.IO;
using System.Text;

namespace Demo.MemoryStreams
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = "Hello\r\nWorld";
            var bytes = Encoding.Default.GetBytes(str);
            var ms = new MemoryStream(bytes,0,bytes.Length);
            var retBytes = new byte[bytes.Length];
            ms.Read(retBytes, 0, retBytes.Length);
            ms.Close();
            var retStr = Encoding.Default.GetString(retBytes);
            Console.WriteLine(retStr);
            Console.ReadKey();
        }
    }
}
