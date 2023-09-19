using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyKursPortfolio.Models;

namespace MyKursPortfolio.Controllers
{
    public class MessageController : Controller
    {
        MyPortfolioDbEntities db=new MyPortfolioDbEntities();
        public ActionResult Index()
        {
            var values = db.Contact.ToList();
            return View(values);
        }
        
        public ActionResult DeleteMessage(int id) 
        {
            var values = db.Contact.Find(id);
            db.Contact.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        
        }
    }
}