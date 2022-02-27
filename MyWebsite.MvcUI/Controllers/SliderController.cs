using Microsoft.AspNetCore.Mvc;
using MyWebsite.Business.Abstract;
using MyWebsite.MvcUI.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebsite.MvcUI.Controllers
{
    public class SliderController : Controller
    {
        readonly ISliderService _sliderService;

        public SliderController(ISliderService sliderService)
        {
            _sliderService = sliderService;
        }

        [HttpGet("SonHaberler/{id}/{title}", Name = "SonHaberler")]
        public IActionResult GetSliderById(int id, string title)
        {
            var slider = _sliderService.Get(x => x.Id == id & !x.IsDeleted);
            if (slider == null)
            {

                return NotFound();
            }

            var str = ChangeCharsToEnglish(slider.Title.ToLower());
            // Get the actual friendly version of the title.
            string friendlyTitle = FriendlyUrlHelper.GetFriendlyTitle(str);

            // Compare the title with the friendly title.
            if (!string.Equals(friendlyTitle, title, StringComparison.Ordinal))
            {
                // If the title is null, empty or does not match the friendly title, return a 301 Permanent
                // Redirect to the correct friendly URL.
                return this.RedirectToRoutePermanent("SonHaberler", new { title = friendlyTitle.ToLower() });
            }

            return View(slider);
        }

        private static string ChangeCharsToEnglish(string str)
        {
            return str.Replace("ö", "o").Replace("ü", "u").Replace("ç", "c").Replace("ğ", "g").Replace("ş", "s").Replace("ı", "i");
        }
    }
}
