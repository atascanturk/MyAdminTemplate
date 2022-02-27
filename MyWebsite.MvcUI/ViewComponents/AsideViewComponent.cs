using Microsoft.AspNetCore.Mvc;
using MyWebsite.Business.Abstract;
using MyWebsite.MvcUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebsite.MvcUI.ViewComponents
{
    public class AsideViewComponent :ViewComponent
    {
        ISocialMediaService _socialMediaService;
        IAnnouncementService _announcementService;

        public AsideViewComponent(ISocialMediaService socialMediaService, IAnnouncementService announcementService)
        {
            _socialMediaService = socialMediaService;
            _announcementService = announcementService;
        }

        public IViewComponentResult Invoke()
        {
            var socialMedia = _socialMediaService.Get(x=>x.Id==1);
            var announcements = _announcementService.GetAllByNonDeleted().OrderByDescending(x=>x.Id).Take(14).ToList();

            var asideViewModel = new AsideViewModel { Announcements = announcements, SocialMedia = socialMedia };

            return View(asideViewModel);
        }
    }
}
