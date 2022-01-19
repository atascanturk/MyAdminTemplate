using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyWebsite.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebsite.MvcUI.Areas.Admin.Controllers
{
    [Area("WNqGRjUh3JPe")]
   [Authorize(Roles ="SuperAdmin,Developer")]
    public class HomeController : Controller
    {
        IContactService _contactService;
        INewsService _newsService;
        IAnnouncementService _announcementService;

        public HomeController(IContactService contactService, INewsService newsService, IAnnouncementService announcementService)
        {
            _contactService = contactService;
            _newsService = newsService;
            _announcementService = announcementService;
        }

        public IActionResult Index()
        {
            ViewBag.UnReadContact = _contactService.GetAll(x => !x.IsRead).Count;
            ViewBag.AnnouncementCount = _announcementService.GetAll(x => !x.IsDeleted).Count;
            ViewBag.NewsCount = _newsService.GetAll(x => !x.IsDeleted).Count;
            return View();
        }
    }
}
