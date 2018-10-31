using System;
using System.Collections;

namespace Demo.ArrayLists
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new ArrayList();
            list.Add(1);
            list.Add("2");
            list.Add(true);
            list.AddRange(new[] { 5, 3, 2, 4 });
            Console.WriteLine("原始：");
            foreach (var o in list)
            {
                Console.Write(o + " ");
            }
            Console.WriteLine();
            Console.WriteLine("反转：");
            list.Reverse();
            foreach (var o in list)
            {
                Console.Write(o + " ");
            }
            Console.WriteLine();
            /*Console.WriteLine("排序：");
            list.Sort();
            foreach (var o in list)
            {
                Console.Write(o + " ");
            }
            Console.WriteLine();*/
            Console.WriteLine("Capacity：" + list.Capacity);
            Console.WriteLine("Count：" + list.Count);
            Console.ReadKey();
        }
    }
}
