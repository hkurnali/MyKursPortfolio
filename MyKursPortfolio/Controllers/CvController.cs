using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyKursPortfolio.Models;

namespace MyKursPortfolio.Controllers
{
    public class CvController : Controller
    {
        MyPortfolioDbEntities db=new MyPortfolioDbEntities();

        public ActionResult Index()
        {
            var values = db.Cv.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult UpdateCv(int id)
        { 
            var values=db.Cv.Find(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult UpdateCv(Cv cv) 
        {
            var values = db.Cv.Find(cv.CvID);
            values.CvURL=cv.CvURL;
            db.SaveChanges();
            return RedirectToAction("Index");
        
        }
    }
}