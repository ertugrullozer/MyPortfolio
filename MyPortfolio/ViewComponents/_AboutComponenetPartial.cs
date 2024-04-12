using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;
using MyPortfolio.DAL.Entities;

namespace MyPortfolio.ViewComponents
{
    public class _AboutComponenetPartial:ViewComponent
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.aboutTitle=context.Abouts.Select(x => x.Title).FirstOrDefault();
            ViewBag.aboutSubDesctiption= context.Abouts.Select(x=>x.SubDescription).FirstOrDefault();
            ViewBag.aboutDetail=context.Abouts.Select(x=>x.Details).FirstOrDefault();
            return View();
        }
    }
}
