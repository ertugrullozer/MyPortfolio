﻿using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents
{
    public class _FeatureComponentPartial:ViewComponent
    {
        MyPortfolioContext context= new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values=context.Features.ToList();

                return View(values);
        }
    }
}
