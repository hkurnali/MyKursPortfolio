using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using MyKursPortfolio.Models;

namespace MyKursPortfolio.Controllers
{
    public class LoginController : Controller
    { MyPortfolioDbEntities db=new MyPortfolioDbEntities();
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Admin p )
        {    var valius=db.Admin.FirstOrDefault(x=>x.Username==p.Username && x.Password==p.Password);
            if (valius!=null)
            {

                FormsAuthentication.SetAuthCookie(valius.NameSurname, false);
                Session["username"]=valius.Username.ToString();
                return RedirectToAction("Index", "Service");

            }
            return View();
        }
    }
}