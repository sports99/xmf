using CourseMangar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CourseMangar.Migrations.Seeds
{
    public class ActionLinkCreator
    {
        private readonly CourseMangar.Models.CourseMangarEntities _context;
        public ActionLinkCreator(CourseMangar.Models.CourseMangarEntities context)
        {
            _context = context;

        }
        public void Seed()
        {
            var initialActionLinks = new List<Actionlinks>
            {
                new Actionlinks
                {
                    Name = "主页",
                    Controller ="Home",
                    Action = "Index"
                }
            };
            foreach(var action in initialActionLinks)
            {
                if (_context.Actionlinks.Any(r => r.Name == action.Name))
                {
                    continue;
                }
                _context.Actionlinks.Add(action);
            }
            _context.SaveChanges();
        }
    }
}