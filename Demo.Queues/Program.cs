using System;
using System.Collections;

namespace Demo.Queues
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
            Console.WriteLine("入队：");
            var queue = new Queue();
            foreach (var o in list)
            {
                queue.Enqueue(o);
                Console.Write(o + " ");
            }
            Console.WriteLine();
            Console.WriteLine("出队：");
            while (queue.Count > 0)
            {
                Console.Write(queue.Dequeue() + " ");
            }
            Console.ReadKey();
        }
    }
}
