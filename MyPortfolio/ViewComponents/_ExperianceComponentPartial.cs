using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.ViewComponents
{
    public class _ExperianceComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke() { 
            return View();
                }
    }
}
