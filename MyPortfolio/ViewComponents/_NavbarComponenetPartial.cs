using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.ViewComponents
{
    public class _NavbarComponenetPartial:ViewComponent
    {
        public IViewComponentResult Invoke() { return View(); }
    }
}
