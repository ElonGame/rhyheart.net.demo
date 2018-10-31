using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Demo.Attributes;

[assembly: Version("Test Assembly", "1.0", "2018-10-22", "初始版本")]
namespace Demo.Attributes
{
    [Version("Test Class", "1.0", "2018-10-22", "初始版本")]
    [Helper("double class desc")]
    [Helper("this is test class")]
    public class Test
    {
        [Version("Test1 Method", "1.0", "2018-10-22", "初始版本")]
        [Helper("this is test1 method")]
        public void Test1()
        {

        }

        [Version("Test2 Method", "1.0", "2018-10-22", "初始版本")]
        [Helper("this is test2 method")]
        public void Test2()
        {

        }

        [Version("Test3 Method", "1.0", "2018-10-22", "初始版本")]
        [Helper("this is test3 method")]
        public void Test3()
        {

        }
    }
}
