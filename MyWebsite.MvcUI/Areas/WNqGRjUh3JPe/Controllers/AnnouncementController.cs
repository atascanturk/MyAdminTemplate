using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyWebsite.Business.Abstract;
using MyWebsite.Entities.Concrete;
using MyWebsite.Entities.Dtos;
using MyWebsite.Mvc.Helpers.Abstract;
using MyWebsite.MvcUI.Areas.Admin.Models;
using MyWebsite.MvcUI.Helpers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebsite.MvcUI.Areas.Admin.Controllers
{
    [Area("WNqGRjUh3JPe")]
    [Authorize(Roles = "SuperAdmin,Developer")]
    public class AnnouncementController : BaseController
    {
        IAnnouncementService _announcementService;

        public AnnouncementController(IAnnouncementService announcementService, UserManager<User> userManager , IMapper mapper, IImageHelper imageHelper) : base(userManager, mapper, imageHelper)
        {
            _announcementService = announcementService;
        }

        public IActionResult Index()
        {
           var announcements = _announcementService.GetAllByNonDeleted();
            return View(announcements);
        }

        [HttpGet("WNqGRjUh3JPe/getannouncement/{id}/{title}", Name = "GetAnnouncement")]        
        public IActionResult GetAnnouncement(int id, string title)
        {
            var announcement = _announcementService.Get(x => x.Id == id);

            if (announcement == null)            {
                
               return NotFound();
            }

            // Get the actual friendly version of the title.
            string friendlyTitle = FriendlyUrlHelper.GetFriendlyTitle(announcement.Title);

            // Compare the title with the friendly title.
            if (!string.Equals(friendlyTitle, title, StringComparison.Ordinal))
            {
                // If the title is null, empty or does not match the friendly title, return a 301 Permanent
                // Redirect to the correct friendly URL.
                return this.RedirectToRoutePermanent("GetAnnouncement", new { id = id, title = friendlyTitle });
            }
            return View();
        }

        [HttpGet]
        public IActionResult AddAnnouncement()
        {            
            return View();
        }


        [HttpPost]
        public IActionResult AddAnnouncement(AnnouncementAddViewModel announcementAddViewModel)
        {
          var announcement =  Mapper.Map<Announcement>(announcementAddViewModel);
            announcement.UserId = LoggedInUser.Id;
            _announcementService.Add(announcement);
            return RedirectToAction("Index","Announcement");
        }

        [HttpPost]
        public IActionResult DeleteAnnouncement(int id)
        {
           var announcement = _announcementService.Get(x => x.Id == id);
            announcement.IsDeleted = true;
            var jsonAnn = JsonConvert.SerializeObject(announcement);
            _announcementService.Update(announcement);
            return Json(jsonAnn);
        }

        [HttpGet]
        public IActionResult UpdateAnnouncement(int id)
        {
            var announcement = _announcementService.Get(x => x.Id == id);
            var announcementUpdateDto = Mapper.Map<AnnouncementUpdateDto>(announcement);

            return View(announcementUpdateDto);
        }
        [HttpPost]
        public IActionResult UpdateAnnouncement(AnnouncementUpdateDto announcementUpdateDto)
        {
            if (ModelState.IsValid)
            {
                var announcement = Mapper.Map<Announcement>(announcementUpdateDto);
                announcement.UserId = LoggedInUser.Id;
                _announcementService.Update(announcement);
                return RedirectToAction("Index");
            }

            return View();
        }

    }
}
