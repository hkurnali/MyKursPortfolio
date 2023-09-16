using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyKursPortfolio.Models;
using Newtonsoft.Json.Linq;

namespace MyKursPortfolio.Controllers
{
    public class StatisticController : Controller
    {
       MyPortfolioDbEntities db=new MyPortfolioDbEntities();
        public ActionResult Index()
        {
            ViewBag.totalProjectCount = db.Project.Count();
            ViewBag.totalTestimonialCount = db.Testimonial.Count();
            ViewBag.sumWorkDay = db.Project.Sum(x=>x.ComplateDay);
            ViewBag.avgWorkDay=db.Project.Average(x=>x.ComplateDay);
            ViewBag.avgPrice=db.Project.Average(x=>x.Price);            
            var value=db.Project.Max(x=>x.Price);
            ViewBag.maxPriceProject = db.Project.Where(x => x.Price == value).Select(y=>y.Title).FirstOrDefault();
            //select* from Project where Price = (select MAX(Price) from Project)
            return View();
        }
    }
}