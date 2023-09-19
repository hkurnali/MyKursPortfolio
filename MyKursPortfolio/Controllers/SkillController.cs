using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyKursPortfolio.Models;

namespace MyKursPortfolio.Controllers
{
    public class SkillController : Controller
    {
        MyPortfolioDbEntities db=new MyPortfolioDbEntities();
        public ActionResult Index()
        {
            var values = db.Skill.ToList();
            return View(values);
        }

        public ActionResult DeleteSkill(int id)
        {  var values = db.Skill.Find(id);
            db.Skill.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult AddSkill()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddSkill(Skill skill)
        {
            db.Skill.Add(skill);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateSkill(int id) 
        {
            var values = db.Skill.Find(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult UpdateSkill(Skill skill)
        {
            var values = db.Skill.Find(skill.SkillID);
            values.Title= skill.Title;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}