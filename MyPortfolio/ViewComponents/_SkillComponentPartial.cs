using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents
{
    public class _SkillComponentPartial:ViewComponent
    {
        MyPortfolioContext context= new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var value= context.Skills.ToList();
            return View(value);
        }
    }
}
