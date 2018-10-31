using System;
using System.Collections;

namespace Demo.Stacks
{
    class Program
    {
        static void Main(string[] args)
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

            Console.ReadKey();
        }
    }
}
