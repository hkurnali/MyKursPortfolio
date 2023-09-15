using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyKursPortfolio.Controllers
{
    public class TestimonialController : Controller
    {
        // GET: Testimonial
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AddTestimonial()
        {
            return View();
        }
    }
}