using System;
using System.Collections;

namespace Demo.Stacks
{
    class Program
    {
        static void Main(string[] args)
        {
            Test();
            Test2();
            Console.ReadKey();
        }

        private static void Test2()
        {
            Console.WriteLine("自定义栈");
            var stack = new MyStack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            var data1 = stack.Pop();
            var data2 = stack.Pop();
            var data3 = stack.Pop();
            Console.WriteLine($"data1:{data1} data2:{data2} data3:{data3}");

        }

        private static void Test()
        {
            var list = new ArrayList();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add("Hello");
            list.Add("World");
            Console.WriteLine("入栈：");
            var stack = new Stack();
            foreach (var o in list)
            {
                stack.Push(o);
                Console.Write(o + " ");
            }
            Console.WriteLine();

            Console.WriteLine("出栈：");
            while (stack.Count > 0)
            {
                Console.Write(stack.Pop() + " ");
            }
            Console.WriteLine();


        }
    }
}
