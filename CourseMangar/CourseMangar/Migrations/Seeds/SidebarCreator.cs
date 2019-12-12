using CourseMangar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CourseMangar.Migrations.Seeds
{
    public class SidebarCreator
    {
        private readonly CourseMangar.Models.CourseMangarEntities _context;
        public SidebarCreator(CourseMangar.Models.CourseMangarEntities context)
        {
            _context = context;

        }
        public void Seed()
        {
            var initialSidebars = new List<Sidebars>
            {
                new Sidebars
                {
                    Name = "班级管理",
                    Controller ="Class",
                    Action = "Index"
                },
                 new Sidebars
                {
                    Name = "老师管理",
                    Controller ="Teacher",
                    Action = "Index"
                },
                  new Sidebars
                {
                    Name = "学生管理",
                    Controller ="Student",
                    Action = "Index"
                },
                   new Sidebars
                {
                    Name = "课程科目管理",
                    Controller ="Course",
                    Action = "Index"
                },
                    new Sidebars
                {
                    Name = "课程安排",
                    Controller ="CoursMangement",
                    Action = "Index"
                },
                     new Sidebars
                {
                    Name = "顶部导航栏管理",
                    Controller ="Actionlink",
                    Action = "Index"
                },
                      new Sidebars
                {
                    Name = "侧边栏管理",
                    Controller ="Sidebar",
                    Action = "Index"
                },
            };
            foreach (var bar in initialSidebars)
            {
                if (_context.Sidebars.Any(r => r.Name == bar.Name))
                {
                    continue;
                }
                _context.Sidebars.Add(bar);
            }
            _context.SaveChanges();
        }
    }
}
    
