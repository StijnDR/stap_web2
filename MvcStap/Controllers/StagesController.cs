using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcStap.Models;

namespace MvcStap.Controllers
{
    public class StagesController : Controller
    {
        private StageDBContext db = new StageDBContext();

        //
        // GET: /Stages/

        public ActionResult Index()
        {
            return View(db.Stages.ToList());
        }

        //
        // GET: /Stages/Details/5

        public ActionResult Details(int id = 0)
        {
            Stage stage = db.Stages.Find(id);
            if (stage == null)
            {
                return HttpNotFound();
            }
            return View(stage);
        }

        //
        // GET: /Stages/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Stages/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Stage stage)
        {
            if (ModelState.IsValid)
            {
                db.Stages.Add(stage);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(stage);
        }

        //
        // GET: /Stages/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Stage stage = db.Stages.Find(id);
            if (stage == null)
            {
                return HttpNotFound();
            }
            return View(stage);
        }

        //
        // POST: /Stages/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Stage stage)
        {
            if (ModelState.IsValid)
            {
                db.Entry(stage).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(stage);
        }

        //
        // GET: /Stages/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Stage stage = db.Stages.Find(id);
            if (stage == null)
            {
                return HttpNotFound();
            }
            return View(stage);
        }

        //
        // POST: /Stages/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Stage stage = db.Stages.Find(id);
            db.Stages.Remove(stage);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}