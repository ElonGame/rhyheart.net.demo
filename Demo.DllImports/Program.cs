using System;
using System.Runtime.InteropServices;

namespace Demo.DllImports
{
    class Program
    {
        [DllImport("User32.dll")]
        public static extern int MessageBox(int hParent, string Message, string Caption, int Type);

        static void Main(string[] args)
        {
            MessageBox(0, "Hello", "Message", 0);

            Console.WriteLine("Hello World!");
        }
    }
}
