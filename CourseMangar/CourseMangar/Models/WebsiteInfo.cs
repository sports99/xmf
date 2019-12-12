using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CourseMangar.Models
{
    public class WebsiteInfo
    {


        public const string SiteName = "课程管理系统";

        public List<Actionlinks> ActionLinks { get; set; }

        public WebsiteInfo()
        {
            var db = new CourseMangarEntities();
            ActionLinks = db.Actionlinks.ToList();
        }
    }
}