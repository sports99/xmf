using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CourseMangar.Filters;
using CourseMangar.Models;

namespace CourseMangar.Controllers
{
    [RequireAuthentication]
    [ActionResultExceptionFilter]   
    public class HomeController : Controller
    {
        private CourseMangarEntities db = new CourseMangarEntities();
        public ActionResult Index()
        {
            
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [ChildActionOnly]

        public ActionResult Navbar()
        {
            var site = new WebsiteInfo();
            ViewBag.Site = site;
            
            return PartialView("~/Views/Shared/Navbar.cshtml");
        }
        [ChildActionOnly]

        public ActionResult SideBar()
        {
            var sidebars = db.Sidebars.ToList();
            ViewBag.Sidebars = sidebars;
            return PartialView("~/Views/Shared/SideBar.cshtml");
        }
    }
}