using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CourseMangar.Models
{

    public partial class Classes
    {
        [Display(Name="班主任")]
        public string TeacherName {
            get
            {
                if (!TeacherId.HasValue)
                {
                    return "";
                }
                CourseMangarEntities db = new CourseMangarEntities();
                var teacher = db.Teachers.Where(t => t.Id == TeacherId.Value).FirstOrDefault();
                if (TeacherId == null)
                {
                    return "";
                }
                return teacher.Name;
            }
    }

    }
}