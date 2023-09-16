using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyKursPortfolio.Models;

namespace MyKursPortfolio.Controllers
{
    public class TestimonialController : Controller
    {
        MyPortfolioDbEntities  db=new MyPortfolioDbEntities();
        // GET: Testimonial
        public ActionResult Index()
        {
            var values = db.Testimonial.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddTestimonial()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddTestimonial(Testimonial testimonial)
        {
             db.Testimonial.Add(testimonial);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteTestimonial(int id)
        {
            var values = db.Testimonial.Find(id);
            db.Testimonial.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateTestimonial(int id)
        {
            var values = db.Testimonial.Find(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult UpdateTestimonial(Testimonial testimonial)
        {
            var values = db.Testimonial.Find(testimonial.TestimonialID);
            values.NameSurname = testimonial.NameSurname;
            values.Comment = testimonial.Comment;
            values.Title=testimonial.Title;
            values.Image=testimonial.Image;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}