using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Myproduct.Models;

namespace Myproduct.Controllers
{
    public class MyproductclassesController : Controller
    {
        private MyproductContext db = new MyproductContext();

        // GET: Myproductclasses
        public ActionResult Index()
        {
            return View(db.Myproductclasses.ToList());
        }

        // GET: Myproductclasses/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Myproductclass myproductclass = db.Myproductclasses.Find(id);
            if (myproductclass == null)
            {
                return HttpNotFound();
            }
            return View(myproductclass);
        }

        // GET: Myproductclasses/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Myproductclasses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,name,category,Orderdate,productquality,productprise")] Myproductclass myproductclass)
        {
            if (ModelState.IsValid)
            {
                db.Myproductclasses.Add(myproductclass);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(myproductclass);
        }

        // GET: Myproductclasses/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Myproductclass myproductclass = db.Myproductclasses.Find(id);
            if (myproductclass == null)
            {
                return HttpNotFound();
            }
            return View(myproductclass);
        }

        // POST: Myproductclasses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,name,category,Orderdate,productquality,productprise")] Myproductclass myproductclass)
        {
            if (ModelState.IsValid)
            {
                db.Entry(myproductclass).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(myproductclass);
        }

        // GET: Myproductclasses/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Myproductclass myproductclass = db.Myproductclasses.Find(id);
            if (myproductclass == null)
            {
                return HttpNotFound();
            }
            return View(myproductclass);
        }

        // POST: Myproductclasses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Myproductclass myproductclass = db.Myproductclasses.Find(id);
            db.Myproductclasses.Remove(myproductclass);
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
