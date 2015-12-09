using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PassionProject2.Models;

namespace PassionProject2.Controllers
{
    public class listings2Controller : Controller
    {
        private TinyHouseEntities3 db = new TinyHouseEntities3();

        // GET: listings2
        public ActionResult Index()
        {
            return View(db.listings2.ToList());
        }

        // GET: listings2/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            listings2 listings2 = db.listings2.Find(id);
            if (listings2 == null)
            {
                return HttpNotFound();
            }
            return View(listings2);
        }

        // GET: listings2/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: listings2/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Image,Description,Accomodates,Bathroom,Location")] listings2 listings2)
        {
            if (ModelState.IsValid)
            {
                db.listings2.Add(listings2);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(listings2);
        }

        // GET: listings2/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            listings2 listings2 = db.listings2.Find(id);
            if (listings2 == null)
            {
                return HttpNotFound();
            }
            return View(listings2);
        }

        // POST: listings2/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Image,Description,Accomodates,Bathroom,Location")] listings2 listings2)
        {
            if (ModelState.IsValid)
            {
                db.Entry(listings2).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(listings2);
        }

        // GET: listings2/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            listings2 listings2 = db.listings2.Find(id);
            if (listings2 == null)
            {
                return HttpNotFound();
            }
            return View(listings2);
        }

        // POST: listings2/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            listings2 listings2 = db.listings2.Find(id);
            db.listings2.Remove(listings2);
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
