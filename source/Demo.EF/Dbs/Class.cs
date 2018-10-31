using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.EF.Dbs
{
    public class Class
    {
        /// <summary>
        /// 主键ID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 班级编号
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 班级名称
        /// </summary>
        public string Name { get; set; }
    }
}
