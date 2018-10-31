using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Attributes
{
    //只有当AllowMultiple（多次特性）为true且Inherited（允许继承）为true时，子类的特性才不会覆盖父类
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = true)]
    public class VersionAttribute : Attribute
    {
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 版本
        /// </summary>
        public string Ver { get; set; }

        /// <summary>
        /// 日期
        /// </summary>
        public string Date { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }

        public VersionAttribute(string name, string ver, string date, string remark)
        {
            Name = name;
            Ver = ver;
            Date = date;
            Remark = remark;
        }
    }
}
