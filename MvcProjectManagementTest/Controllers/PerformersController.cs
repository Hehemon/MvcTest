using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MvcProjectManagementTest.Models;

namespace MvcProjectManagementTest.Controllers
{
    public class PerformersController : Controller
    {
        private TaskManagerDbContext db = new TaskManagerDbContext();

        // GET: Performers
        public ActionResult Index()
        {
            return View(db.Performers.ToList());
        }

        // GET: Performers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Performer performer = db.Performers.Find(id);
            if (performer == null)
            {
                return HttpNotFound();
            }
            return View(performer);
        }

        // GET: Performers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Performers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Surname,Name,MiddleName")] Performer performer)
        {
            if (ModelState.IsValid)
            {
                db.Performers.Add(performer);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(performer);
        }

        // GET: Performers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Performer performer = db.Performers.Find(id);
            if (performer == null)
            {
                return HttpNotFound();
            }
            return View(performer);
        }

        // POST: Performers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Surname,Name,MiddleName")] Performer performer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(performer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(performer);
        }

        // GET: Performers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Performer performer = db.Performers.Find(id);
            if (performer == null)
            {
                return HttpNotFound();
            }
            return View(performer);
        }

        // POST: Performers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Performer performer = db.Performers.Find(id);
            db.Performers.Remove(performer);
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
