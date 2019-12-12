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
    public class ActionlinksController : Controller
    {
        private CourseMangarEntities db = new CourseMangarEntities();

        // GET: Actionlinks
        public ActionResult Index()
        {
            return View(db.Actionlinks.ToList());
        }

        // GET: Actionlinks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Actionlinks actionlinks = db.Actionlinks.Find(id);
            if (actionlinks == null)
            {
                return HttpNotFound();
            }
            return View(actionlinks);
        }

        // GET: Actionlinks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Actionlinks/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Controller,Action")] Actionlinks actionlinks)
        {
            if (ModelState.IsValid)
            {
                db.Actionlinks.Add(actionlinks);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(actionlinks);
        }

        // GET: Actionlinks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Actionlinks actionlinks = db.Actionlinks.Find(id);
            if (actionlinks == null)
            {
                return HttpNotFound();
            }
            return View(actionlinks);
        }

        // POST: Actionlinks/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Controller,Action")] Actionlinks actionlinks)
        {
            if (ModelState.IsValid)
            {
                db.Entry(actionlinks).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(actionlinks);
        }

        // GET: Actionlinks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Actionlinks actionlinks = db.Actionlinks.Find(id);
            if (actionlinks == null)
            {
                return HttpNotFound();
            }
            return View(actionlinks);
        }

        // POST: Actionlinks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Actionlinks actionlinks = db.Actionlinks.Find(id);
            db.Actionlinks.Remove(actionlinks);
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
