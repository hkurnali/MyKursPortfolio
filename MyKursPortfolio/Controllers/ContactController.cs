using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyKursPortfolio.Models;

namespace MyKursPortfolio.Controllers
{
    public class ContactController : Controller
    { MyPortfolioDbEntities db=new MyPortfolioDbEntities();
        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.decription=db.Address.Select(x=>x.Description).FirstOrDefault();
            ViewBag.phone=db.Address.Select(x => x.Phone).FirstOrDefault();
            ViewBag.addressDetail = db.Address.Select(x => x.AddressDetail).FirstOrDefault();
            ViewBag.mail = db.Address.Select(x => x.Mail).FirstOrDefault();
            return View();
        }
        [HttpPost]
        public ActionResult Index(Contact contact)
        {
             db.Contact.Add(contact);
            db.SaveChanges();
            return RedirectToAction("Index","Default");
        }
        public ActionResult PartialScript()
        {
            return PartialView();
        }
       

    }
}