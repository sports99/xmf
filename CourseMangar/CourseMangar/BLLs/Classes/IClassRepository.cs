using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseMangar.BLLs.Classes
{
  public  interface IClassRepository
    {
        List<CoursDetail> GetClassCourse(int id);
    }
}
