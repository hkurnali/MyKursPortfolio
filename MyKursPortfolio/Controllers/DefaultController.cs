﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyKursPortfolio.Models;
namespace MyKursPortfolio.Controllers
{
    public class DefaultController : Controller
    {
        MyPortfolioDbEntities db=new MyPortfolioDbEntities();
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialHead()
        {
            return PartialView();
        }
        public PartialViewResult PartialHeader()
        {
            return PartialView();
        }
        public PartialViewResult PartialQuickContact()
        {
            return PartialView();
        }
        public PartialViewResult PartialFeature()
        {
            return PartialView();
        }
        public PartialViewResult PartialService()
        {
            var values = db.Service.ToList();
            return PartialView( values);
        }
        public PartialViewResult PartialSkill()
        {
            var values = db.Skill.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialAward() 
        {
            return PartialView();
        }
        public PartialViewResult PartialTestimonial()
        {
            var values=db.Testimonial.ToList();
            return PartialView(values);
        }
    }
}