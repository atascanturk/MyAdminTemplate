using Microsoft.AspNetCore.Mvc;
using MyWebsite.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebsite.MvcUI.ViewComponents
{
    public class NewsViewComponent :ViewComponent
    {
        INewsService _newsService;

        public NewsViewComponent(INewsService newsService)
        {
            _newsService = newsService;
        }

        public IViewComponentResult Invoke()
        {
            var news = _newsService.GetAllByNonDeletedAndActive().OrderByDescending(x=>x.Id).Take(9).ToList();

            return View(news);
        }
    }
}
