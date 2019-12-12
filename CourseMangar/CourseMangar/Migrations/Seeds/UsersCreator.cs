using CourseMangar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CourseMangar.Migrations.Seeds
{
    public class UsersCreator
    {
        private readonly CourseMangar.Models.CourseMangarEntities _context;
        public UsersCreator(CourseMangar.Models.CourseMangarEntities context)
        {
            _context = context;

        }

        public void Seed()
        {
            var initialUsers = new List<Users>
            {
                new Users
                {
                    Account = "admin",
                    Name = "admin",
                    Password ="E10ADC3949BA59ABBE56E057F20F883E",
                    
                }
            };
            foreach (var action in initialUsers)
            {
                if (_context.Users.Any(r => r.Name == action.Name))
                {
                    continue;
                }
                _context.Users.Add(action);
            }
            _context.SaveChanges();
        }
    }
}