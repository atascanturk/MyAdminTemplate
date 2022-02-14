using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyWebsite.Business.Abstract;
using MyWebsite.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebsite.MvcUI.Areas.WNqGRjUh3JPe.Controllers
{
    [Area("WNqGRjUh3JPe")]
    [Authorize(Roles ="SuperAdmin,Developer")]
    public class SeoController : Controller
    {
        ISeoService _seoService;

        public SeoController(ISeoService seoService)
        {
            _seoService = seoService;
        }

        public IActionResult Index()
        {
          var seo =  _seoService.Get(x => x.Id == 1);
            return View(seo);
        }

        public IActionResult Update(Seo seo)
        {
            seo.UpdatedDate = DateTime.Now;
            _seoService.Update(seo);            
            return Json("");
        }
    }
}
