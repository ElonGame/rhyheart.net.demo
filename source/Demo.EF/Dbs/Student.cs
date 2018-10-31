using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Demo.EF.Dbs
{
    public class Student
    {
        /// <summary>
        /// 主键ID
        /// </summary>
        public int Id { get; set; }

        [ForeignKey("ClassId")]
        public virtual Class Class { get; set; }

        /// <summary>
        /// 班级ID
        /// </summary>
        public int ClassId { get; set; }


        /// <summary>
        /// 地址
        /// </summary>
        [ForeignKey("AddressId")]
        public Address Address { get; set; }

        /// <summary>
        /// 区域ID
        /// </summary>
        public int AddressId { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 年龄
        /// </summary>
        public int Age { get; set; }
    }
}
