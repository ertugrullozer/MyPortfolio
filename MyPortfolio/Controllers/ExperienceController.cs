using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;
using MyPortfolio.DAL.Entities;

namespace MyPortfolio.Controllers
{
    public class ExperienceController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IActionResult ExperienceList()
        {
            var values= context.Experiences.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateExperiance()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateExperiance(Experience experience) 
        { 
            context.Experiences.Add(experience);
            context.SaveChanges();
            return RedirectToAction("ExperienceList");
        }
     
        public IActionResult DeleteExperience(int id) 
        {
            var value = context.Experiences.Find(id);
            context.Experiences.Remove(value);
            context.SaveChanges();
            return RedirectToAction("ExperienceList");
        }
        [HttpGet]
        public IActionResult UpdateExperiance(int id)
        {
            var value = context.Experiences.Find(id);
          return View(value);
        }
        [HttpPost]
        public IActionResult UpdateExperiance(Experience experience)
        {
            context.Experiences.Update(experience);
            context.SaveChanges();
            return RedirectToAction("ExperienceList");
        }




	}
}
