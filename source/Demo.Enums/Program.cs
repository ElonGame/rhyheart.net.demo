using System;

namespace Demo.Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            var red = Color.Red;
            Console.WriteLine("red:" + red + " " + (int)red);
            var color = (Color)2;
            Console.WriteLine("color:" + color + " " + (int)color);
            Console.ReadKey();
        }
    }
}
