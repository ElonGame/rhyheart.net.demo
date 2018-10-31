using System;
using System.Reflection;

namespace Demo.Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test1();
            //Test2();
            Test3();

            Console.ReadKey();
        }

        static void Test3()
        {
            var attrs = typeof(Child).GetCustomAttributes<DescAttribute>();
            foreach (var attr in attrs)
            {
                Console.WriteLine(attr.Desc);
            }
        }

        static void Test2()
        {
            Console.WriteLine("Test2....");

            var a = typeof(Test).Assembly;
            var av = a.GetCustomAttribute<VersionAttribute>();
            Console.WriteLine("Assembly Version:");
            if (av != null)
                Console.WriteLine($"Name:{av.Name} Ver:{av.Ver} Date:{av.Date} Remark:{av.Remark}");

            var cv = typeof(Test).GetCustomAttribute<VersionAttribute>();
            Console.WriteLine("Class Version:");
            if (cv != null)
                Console.WriteLine($"Name:{cv.Name} Ver:{cv.Ver} Date:{cv.Date} Remark:{cv.Remark}");

            var ms = typeof(Test).GetMethods();
            Console.WriteLine("Method Version:");
            foreach (var m in ms)
            {
                var mv = m.GetCustomAttribute<VersionAttribute>();
                if (mv != null)
                    Console.WriteLine($"Name:{mv.Name} Ver:{mv.Ver} Date:{mv.Date} Remark:{mv.Remark}");
            }
        }

        static void Test1()
        {
            Console.WriteLine("Test1...");

            var testType = typeof(Test);
            var classHelperAttrs = testType.GetCustomAttributes(typeof(HelperAttribute), true);
            foreach (var attr in classHelperAttrs)
            {
                Console.WriteLine(((HelperAttribute)attr).Desc);
            }

            var testMethods = testType.GetMethods();
            foreach (var testMethod in testMethods)
            {
                var methodHelperAttrs = testMethod.GetCustomAttributes(typeof(HelperAttribute), true);
                foreach (var methodHelperAttr in methodHelperAttrs)
                {
                    Console.WriteLine(((HelperAttribute)methodHelperAttr).Desc);
                }
            }
        }
    }
}
