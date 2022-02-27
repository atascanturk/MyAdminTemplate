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
    public class NewsController : Controller
    {
        INewsService _newsService;        

        public NewsController(INewsService newsService)
        {
            _newsService = newsService;            
        }

        [HttpGet("Haberler")]
        public IActionResult Index()
        {       
            var news = _newsService.GetAllByNonDeletedAndActive();
            return View(news);
        }

        [HttpGet("KadinKollari")]
        public IActionResult KadinKollari()
        {
            var news = _newsService.GetAll(x=>!x.IsDeleted & x.IsActive & x.Category.Name =="Kadın Kolları").ToList();
            return View(news);
        }


        [HttpGet("Haberler/{id}/{title}" ,Name ="Haberler")]
        public IActionResult GetNewsById( int id, string title)
        {
            var news = _newsService.GetByIdNonDeletedAndActive(id,null);           
            var newsList = _newsService.GetAllByNonDeletedAndActive().OrderByDescending(x=>x.Id).Take(3).ToList();           

            if (news == null)
            {

                return NotFound();
            }
            var str = ChangeCharsToEnglish(news.Title.ToLower());
            // Get the actual friendly version of the title.
            string friendlyTitle = FriendlyUrlHelper.GetFriendlyTitle(str);

            // Compare the title with the friendly title.
            if (!string.Equals(friendlyTitle, title, StringComparison.Ordinal))
            {
                // If the title is null, empty or does not match the friendly title, return a 301 Permanent
                // Redirect to the correct friendly URL.
                return this.RedirectToRoutePermanent("Haberler", new { title = friendlyTitle.ToLower() });
            }
            return View(new GetNewsViewModel {News=news,NewsList=newsList });
           
        }

        private string ChangeCharsToEnglish(string str)
        {
            return str.Replace("ö", "o").Replace("ü", "u").Replace("ç", "c").Replace("ğ", "g").Replace("ş", "s").Replace("ı","i");
        }
    }
}
