using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Attributes
{
    [AttributeUsage(AttributeTargets.Class,AllowMultiple = true)]
    public class DescAttribute : Attribute
    {
        public string Desc { get; set; }

        public DescAttribute(string desc)
        {
            Desc = desc;
        }

    }
}
