using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using assignment9.Models;

namespace assignment9.Controllers
{
    public class LoversController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Lovers
        public ActionResult Index()
        {
            return View(db.Lovers.ToList());
        }

        // GET: Lovers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lover lover = db.Lovers.Find(id);
            if (lover == null)
            {
                return HttpNotFound();
            }
            return View(lover);
        }

        // GET: Lovers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Lovers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "LoverID,Name,FavDog,LastDog,Date,Bio,PastDog")] Lover lover)
        {
            if (ModelState.IsValid)
            {
                db.Lovers.Add(lover);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(lover);
        }

        // GET: Lovers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lover lover = db.Lovers.Find(id);
            if (lover == null)
            {
                return HttpNotFound();
            }
            return View(lover);
        }

        // POST: Lovers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "LoverID,Name,FavDog,LastDog,Date,Bio,PastDog")] Lover lover)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lover).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(lover);
        }

        // GET: Lovers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lover lover = db.Lovers.Find(id);
            if (lover == null)
            {
                return HttpNotFound();
            }
            return View(lover);
        }

        // POST: Lovers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Lover lover = db.Lovers.Find(id);
            db.Lovers.Remove(lover);
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
