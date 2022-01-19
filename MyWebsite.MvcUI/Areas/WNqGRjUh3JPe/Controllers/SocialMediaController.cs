using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyWebsite.Business.Abstract;
using MyWebsite.Entities.Concrete;
using MyWebsite.MvcUI.Areas.WNqGRjUh3JPe.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebsite.MvcUI.Areas.WNqGRjUh3JPe.Controllers
{
    [Area("WNqGRjUh3JPe")]
    [Authorize(Roles = "SuperAdmin,Developer")]
    public class SocialMediaController : Controller
    {
        ISocialMediaService _socialMediaService;
        IMapper _mapper;

        public SocialMediaController(ISocialMediaService socialMediaService, IMapper mapper)
        {
            _socialMediaService = socialMediaService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var socialMedia = _socialMediaService.GetAll().FirstOrDefault();
           var socialMediaUpdateViewModel = _mapper.Map<SocialMediaUpdateViewModel>(socialMedia);
            return View(socialMediaUpdateViewModel);
        }

        [HttpPost]
        public IActionResult AddSocialMedia(SocialMediaUpdateViewModel socialMediaUpdateViewModel)
        {
            if (!ModelState.IsValid)
            {
                //foreach (var modelState in ViewData.ModelState.Values)
                //{
                //    foreach (var error in modelState.Errors)
                //    {
                //        ModelState.AddModelError("", error.ErrorMessage);
                //    }
                //}
                string error = "HATA : ";
                var message = string.Join("\n HATA : ", ModelState.Values
                    .SelectMany(v => v.Errors)
                    .Select(e => e.ErrorMessage));
                message = error + message;
                
                return this.Json(new { success = false, message = message });
            
            }
            var updatedSocialMedia = _mapper.Map<SocialMedia>(socialMediaUpdateViewModel);
            _socialMediaService.Update(updatedSocialMedia);
            var jsonSocialMedia = JsonConvert.SerializeObject(socialMediaUpdateViewModel);
            return this.Json(new { success = true});
        }
    }
}
