using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.EF.Dto
{
    public class StudentGroupDto
    {
        public int ClassId { get; set; }
        public List<StudentDto> StudentList { get; set; }
    }

    public class StudentDto
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
