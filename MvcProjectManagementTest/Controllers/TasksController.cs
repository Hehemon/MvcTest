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
    public class TasksController : Controller
    {
        private TaskManagerDbContext db = new TaskManagerDbContext();

        // GET: Tasks
        public ActionResult Index()
        {
            return View(db.Tasks.ToList());
        }

        // GET: Tasks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProductTask productTask = db.Tasks.Find(id);
            if (productTask == null)
            {
                return HttpNotFound();
            }
            return View(productTask);
        }

        // GET: Tasks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tasks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,PlannedTime,StartTime,EndTime,Status")] ProductTask productTask)
        {
            if (ModelState.IsValid)
            {
                db.Tasks.Add(productTask);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(productTask);
        }

        // GET: Tasks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProductTask productTask = db.Tasks.Find(id);
            if (productTask == null)
            {
                return HttpNotFound();
            }
            return View(productTask);
        }

        // POST: Tasks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,PlannedTime,StartTime,EndTime,Status")] ProductTask productTask)
        {
            if (ModelState.IsValid)
            {
                db.Entry(productTask).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(productTask);
        }

        // GET: Tasks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProductTask productTask = db.Tasks.Find(id);
            if (productTask == null)
            {
                return HttpNotFound();
            }
            return View(productTask);
        }

        // POST: Tasks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ProductTask productTask = db.Tasks.Find(id);
            db.Tasks.Remove(productTask);
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
