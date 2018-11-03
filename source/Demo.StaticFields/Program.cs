using System;

namespace Demo.StaticFields
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("赋值前：" + MyClass.StaticFiled);
            MyClass.StaticFiled = "Hello";
            Console.WriteLine("赋值后：" + MyClass.StaticFiled);
            MyClass.StaticFiled = "World";
            Console.WriteLine("二次赋值：" + MyClass.StaticFiled);
            Console.ReadKey();
        }
    }
}
