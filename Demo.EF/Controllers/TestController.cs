using System.Collections.Generic;
using System.Linq;
using Demo.EF.Dbs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Demo.EF.Controllers
{
    [Route("test")]
    public class TestController : Controller
    {
        private readonly TestDbContext _db;

        public TestController(TestDbContext db)
        {
            _db = db;
        }

        /// <summary>
        /// 新增数据
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("add")]
        public string Add()
        {
            _db.Classes.AddRange(new List<Class>
            {
                new Class
                {
                    Code = "1401",
                    Name = "物联网1班"
                },
                new Class
                {
                    Code = "1402",
                    Name = "物联网2班"
                }
            });

            var reEntity = _db.Classes.Add(new Class
            {
                Code = "1403",
                Name = "物联网3班"
            });

            _db.SaveChanges();

            _db.Students.AddRange(new List<Student>
            {
                new Student
                {
                    Name = "张三",
                    Age = 20,
                    ClassId = reEntity.Entity.Id
                },
                new Student
                {
                    Name = "李四",
                    Age = 21,
                    ClassId = reEntity.Entity.Id
                },
                new Student
                {
                    Name = "王五",
                    Age = 22,
                    ClassId = reEntity.Entity.Id
                },
            });

            _db.SaveChanges();

            return "add success";
        }

        /// <summary>
        /// 获取普通列表
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("list")]
        public object List()
        {
            var efIncludeList = _db.Students
                .Include(x => x.Class)
                .Include(x => x.Address)
                .Select(x => new
                {
                    Class = x.Class.Name,
                    x.Name,
                    x.Age,
                    x.Address.Province,
                    x.Address.City,
                    x.Address.Town
                }).ToList();

            var efJoinList = _db.Students.Join(_db.Classes, s => s.ClassId, c => c.Id, (s, c) => new
            {
                Class = c.Name,
                s.Name,
                s.Age
            }).ToList();

            var efLinkList = (from s in _db.Students
                join c in _db.Classes
                    on s.ClassId equals c.Id into ics
                from ic in ics.DefaultIfEmpty()
                join a in _db.Addresses
                    on s.AddressId equals a.Id into ias
                from ia in ias.DefaultIfEmpty()
                select new
                {
                    Class = ic != null ? ic.Name : "未知",
                    s.Name,
                    s.Age,
                    Address = ia != null ? $"{ia.Province} {ia.City} {ia.Town}" : "未知"
                }).ToList();

            return new
            {
               efIncludeList,
               efJoinList,
               efLinkList
            };
        }

        /// <summary>
        /// 获取分组列表
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("group")]
        public object Group()
        {
            var efIncludeGroup = _db.Students
                .Include(x => x.Class)
                .Include(x => x.Address)
                .GroupBy(x => x.Class)
                .Select(x => new
                {
                    Class = x.Key.Name,
                    Student = x.Select(y => new
                    {
                        y.Name,
                        y.Age,
                        Address = $"{y.Address.Province} {y.Address.City} {y.Address.Town}"
                    })
                });

            var efJoinGroup = _db.Classes
                .GroupJoin(_db.Students, x => x.Id, y => y.ClassId,
                    (x, y) => new
                    {
                        Class = x.Name,
                        Student = y.Select(z => new
                        {
                            z.Name,
                            z.Age,
                            Address = $"{z.Address.Province} {z.Address.City} {z.Address.Town}"
                        })
                    });

            var linkGroup = from s in _db.Students
                    join c in _db.Classes
                        on s.ClassId equals c.Id into ics
                    from ic in ics.DefaultIfEmpty()
                    join a in _db.Addresses
                        on s.AddressId equals a.Id into ias
                    from ia in ias.DefaultIfEmpty()
                    select new
                    {
                        Class = ic != null ? ic.Name : "未知",
                        s.Name,
                        s.Age,
                        Address = ia != null ? $"{ia.Province} {ia.City} {ia.Town}" : "未知"
                    } into ss
                    group ss by ss.Class into gs
                    select new
                    {
                        Class = gs.Key,
                        Student = gs.Select(x => new
                        {
                            x.Name,
                            x.Age,
                            x.Address
                        })
                    }
                ;

            return new
            {
                efIncludeGroup,
                efJoinGroup,
                linkGroup
            };
        }

    }
}
