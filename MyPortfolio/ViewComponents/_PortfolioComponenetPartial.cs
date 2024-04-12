using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.ViewComponents
{
    public class _PortfolioComponenetPartial:ViewComponent
    {
        public IViewComponentResult Invoke() { return View(); }
    }
}
