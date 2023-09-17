using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyKursPortfolio.Controllers
{
    public class ErrorPageController : Controller
    {
        // GET: ErorPage
        public ActionResult Page404()
        {
            Response.StatusCode = 404;
            return View();
        }
    }
}