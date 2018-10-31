using System;
using System.Collections;

namespace Demo.SortedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            var hashtable = new Hashtable();
            hashtable.Add("003", "王五");
            hashtable.Add("001", "张三");
            hashtable.Add("002", "李四");
            Console.WriteLine("原始：");
            var sortedList = new SortedList();
            foreach (var key in hashtable.Keys)
            {
                sortedList.Add(key, hashtable[key]);
                Console.Write($"{key}-{hashtable[key]} ");
            }
            Console.WriteLine();
            Console.WriteLine("SortedList：");
            foreach (var key in sortedList.Keys)
            {
                Console.Write($"{key}-{sortedList[key]} ");
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
