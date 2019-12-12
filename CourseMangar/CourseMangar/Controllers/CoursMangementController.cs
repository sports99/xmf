using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CourseMangar.Models;

namespace CourseMangar.Controllers
{
    public class CoursMangementController : Controller
    {
        private CourseMangarEntities db = new CourseMangarEntities();

        // GET: CoursMangement
        public ActionResult Index()
        {
            return View(db.CoursMangements.ToList());
        }

        // GET: CoursMangement/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CoursMangements coursMangements = db.CoursMangements.Find(id);
            if (coursMangements == null)
            {
                return HttpNotFound();
            }
            return View(coursMangements);
        }

        // GET: CoursMangement/Create
        public ActionResult Create()
        {
            var classes = db.Classes.ToList();
            ViewBag.Classes = classes;

            var teachers = db.Teachers.ToList();
            ViewBag.Teachers = teachers;

            var courses = db.Courses.ToList();
            ViewBag.Courses = courses;
            return View();
        }

        // POST: CoursMangement/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,ClassId,CourseId,TeacherId")] CoursMangements coursMangements)
        {
            if (ModelState.IsValid)
            {
                db.CoursMangements.Add(coursMangements);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(coursMangements);
        }

        // GET: CoursMangement/Edit/5
        public ActionResult Edit(int? id)
        {
            var classes = db.Classes.ToList();
            ViewBag.Classes = classes;

            var teachers = db.Teachers.ToList();
            ViewBag.Teachers = teachers;

            var courses = db.Courses.ToList();
            ViewBag.Courses = courses;
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CoursMangements coursMangements = db.CoursMangements.Find(id);
            if (coursMangements == null)
            {
                return HttpNotFound();
            }
            return View(coursMangements);
        }

        // POST: CoursMangement/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,ClassId,CourseId,TeacherId")] CoursMangements coursMangements)
        {
            if (ModelState.IsValid)
            {
                db.Entry(coursMangements).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(coursMangements);
        }

        // GET: CoursMangement/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CoursMangements coursMangements = db.CoursMangements.Find(id);
            if (coursMangements == null)
            {
                return HttpNotFound();
            }
            return View(coursMangements);
        }

        // POST: CoursMangement/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CoursMangements coursMangements = db.CoursMangements.Find(id);
            db.CoursMangements.Remove(coursMangements);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
