using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace Demo.Hashtables
{
    class Program
    {
        static void Main(string[] args)
        {
            var hashtable = new Hashtable();
            hashtable.Add("001", "张三");
            hashtable.Add("003", "王五");
            hashtable.Add("002", "李四");
            Console.WriteLine("原始：");
            foreach (var key in hashtable.Keys)
            {
                Console.Write($"{key}-{hashtable[key]} ");
            }
            Console.WriteLine();
            Console.WriteLine("Keys：");
            foreach (var key in hashtable.Keys)
            {
                Console.Write(key + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Values：");
            foreach (var value in hashtable.Values)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
