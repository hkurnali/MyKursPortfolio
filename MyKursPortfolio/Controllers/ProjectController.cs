using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyKursPortfolio.Models;

namespace MyKursPortfolio.Controllers
{
    public class ProjectController : Controller

    {
        MyPortfolioDbEntities db = new MyPortfolioDbEntities();
        // GET: Project
        public ActionResult Index()
        {
            var values=db.Project.ToList();
            return View(values);
        }
    }
}