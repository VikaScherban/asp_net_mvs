using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClassCartoons;

namespace MvcCartoons.Controllers
{
    public class AddCartoonController : Controller
    {
        private DBCartoonsEntities db = new DBCartoonsEntities();
        //
        // GET: /AddCartoon/

        public ActionResult Index()
        {
            return View(db.CARTOONS.ToList());
        }

        //
        // GET: /AddCartoon/Details/5

        public ActionResult Details(int id = 0)
        {
            CARTOONS car = db.CARTOONS.Find(id);
            if (car == null)
            {
                return HttpNotFound();
            }
            return View(car);
        }

        //
        // GET: /AddCartoon/Create

        public ActionResult Create()
        {
            var car = new CARTOONS();
            ViewBag.Statuses = db.DIC_CARTOON_STATUSES.ToList();
            return View(car);
        }

        [HttpPost]
        public ActionResult Create(CARTOONS car)
        {
            if (ModelState.IsValid)
            {
                db.CARTOONS.Add(car);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(car);
        }

        //
        // GET: /AddCartoon/Edit/5

        public ActionResult Edit(int id)
        {
            CARTOONS car = db.CARTOONS.Find(id);
            if (car == null)
            {
                return HttpNotFound();
            }
            ViewBag.CarName = car.CR_NAME;
            return View(car);
        }

        [HttpPost]
        public ActionResult Edit(CARTOONS car)
        {
            if (ModelState.IsValid)
            {
                db.Entry(car).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(car);
        }

        //
        // GET: /AddCartoon/Delete/5

        public ActionResult Delete(int id)
        {
            CARTOONS car = db.CARTOONS.Find(id);
            if (car == null)
            {
                return HttpNotFound();
            }
            ViewBag.CarName = car.CR_NAME;
            return View(car);
        }

        //
        // POST: /Film/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            CARTOONS car = db.CARTOONS.Find(id);
            db.CARTOONS.Remove(car);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
