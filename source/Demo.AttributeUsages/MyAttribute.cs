using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.AttributeUsages
{
    /// <summary>
    /// 参数1，特性可以使用的范围；参数2，特性是否多用；参数3，特性是否可被继承
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
    public class MyAttribute : Attribute
    {

    }
}
