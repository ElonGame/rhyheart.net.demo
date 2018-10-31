using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Attributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    public class HelperAttribute : Attribute
    {
        public string Desc { get; set; }

        public HelperAttribute(string desc)
        {
            Desc = desc;
        }
    }
}
