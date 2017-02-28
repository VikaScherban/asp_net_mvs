using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClassCartoons;

namespace MvcCartoons.Controllers
{
    public class CartoonsController : Controller
    {
        private DBCartoonsEntities db = new DBCartoonsEntities();
        //
        // GET: /Cartoons/

        public ActionResult Index()
        {
            return View(db.DIC_GENRE.ToList());
        }

        public ActionResult CartoonsByGenre(int id)
        {
            ViewBag.CategoryName = db.DIC_GENRE.Where(x => x.GR_ID == id).First().GR_NAME;
            return View(db.CARTOONS.Where(x => x.GENRE_CARTOONS.Any(y => y.GC_GR == id)).ToList());

        }

        /*public ActionResult CartoonDetails(int diractorID, int companyID,  int id)
        {

            return PartialView(db.CARTOONS.Include("DIC_DIRACTORS", "DIC_COMPANY", "CARTOONS").First(x => x.CR_ID == id));
        }*/

        public ActionResult DiractorsByCartoons (int id)
        {
            ViewBag.CartoonName = db.CARTOONS.Where(x => x.CR_ID == id).First().CR_NAME;
            return View(db.DIC_DIRACTORS.Where(x => x.DIRACTORS_CARTOONS.Any(y => y.DK_CR == id)).ToList());
        }

        public ActionResult Cartoons()
        {
            return View(db.CARTOONS.ToList());
        }

        public ActionResult CartoonsByCompany(int id)
        {
            ViewBag.CartoonName = db.CARTOONS.Where(x => x.CR_ID == id).First().CR_NAME;
            return View(db.DIC_COMPANY.Where(x => x.COMPANY_CARTOONS.Any(y => y.CC_CR == id)).ToList());
        }

        public ActionResult Company()
        {
            return View(db.DIC_COUNRTY);
        }

        public ActionResult CartoonsByCountry(int id)
        {
            ViewBag.CountryName = db.DIC_COUNRTY.Where(x => x.CT_ID == id).First().CT_NAME;
            return   View(db.CARTOONS.Where(x => x.COMPANY_CARTOONS.Any(y => y.DIC_COMPANY.DIC_COUNRTY.CT_ID == id)).ToList());
        }
    }
}