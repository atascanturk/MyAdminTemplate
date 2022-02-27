using Microsoft.AspNetCore.Mvc;
using MyWebsite.Business.Abstract;
using MyWebsite.MvcUI.Helpers;
using MyWebsite.MvcUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebsite.MvcUI.Controllers
{
    public class AnnouncementController : Controller
    {
        IAnnouncementService _announcementService;

        public AnnouncementController(IAnnouncementService announcementService)
        {
            _announcementService = announcementService;
        }

        [HttpGet("Duyurular")]
        public IActionResult Index()
        {
            var announcements = _announcementService.GetAllByNonDeleted();
            return View(announcements);
        }

        [HttpGet("Duyuru/{id}/{title}", Name = "Duyuru")]
        public IActionResult Duyurular(int id, string title)
        {
            var announcement = _announcementService.GetAllByNonDeletedWithId(id,null).FirstOrDefault();

            if (announcement == null)
            {

                return NotFound();
            }
            var str = ChangeCharsToEnglish(announcement.Title.ToLower());
            // Get the actual friendly version of the title.
            string friendlyTitle = FriendlyUrlHelper.GetFriendlyTitle(str);

            // Compare the title with the friendly title.
            if (!string.Equals(friendlyTitle, title, StringComparison.Ordinal))
            {
                // If the title is null, empty or does not match the friendly title, return a 301 Permanent
                // Redirect to the correct friendly URL.
                return this.RedirectToRoutePermanent("Duyuru", new { id=id, title = friendlyTitle });
            }
            return View(announcement);
        }

        private string ChangeCharsToEnglish(string str)
        {
            return str.Replace("ö", "o").Replace("ü", "u").Replace("ç", "c").Replace("ğ", "g").Replace("ş", "s").Replace("ı", "i");
        }
    }
}
