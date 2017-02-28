using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClassCartoons;

namespace MvcCartoons.Controllers
{
    public class DiractorController : Controller
    {
        private DBCartoonsEntities db = new DBCartoonsEntities();
        //
        // GET: /Diractor/

        public ActionResult Index()
        {
            return View(db.DIC_DIRACTORS.ToList());
        }

        //
        // GET: /Diractor/Details/5

        public ActionResult Details(int id = 0)
        {
            DIC_DIRACTORS diractors = db.DIC_DIRACTORS.Find(id);
            if (diractors == null)
            {
                return HttpNotFound();
            }
            return View(diractors);
        }

        //
        // GET: /Diractor/Create

        public ActionResult Create()
        {
            var dir = new DIC_DIRACTORS();
            return View(dir);
        }

        [HttpPost]
        public ActionResult Create(DIC_DIRACTORS dir)
        {
            if (ModelState.IsValid)
            {
                db.DIC_DIRACTORS.Add(dir);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dir);
        }

        //
        // GET: /Diractor/Edit/5

        public ActionResult Edit(int id)
        {
            DIC_DIRACTORS dir = db.DIC_DIRACTORS.Find(id);
            if (dir == null)
            {
                return HttpNotFound();
            }
            ViewBag.DirName = dir.DR_NAME;
            return View(dir);
        }

        [HttpPost]
        public ActionResult Edit(DIC_DIRACTORS dir)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dir).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dir);
        }

        //
        // GET: /Diractor/Delete/5


        public ActionResult Delete(int id)
        {
            DIC_DIRACTORS dir = db.DIC_DIRACTORS.Find(id);
            if (dir == null)
            {
                return HttpNotFound();
            }
            ViewBag.DirName = dir.DR_NAME;
            return View(dir);
        }

        //
        // POST: /Film/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            DIC_DIRACTORS dir = db.DIC_DIRACTORS.Find(id);
            db.DIC_DIRACTORS.Remove(dir);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
