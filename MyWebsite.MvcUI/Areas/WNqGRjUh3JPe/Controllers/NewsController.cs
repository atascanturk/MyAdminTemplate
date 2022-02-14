using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyWebsite.Business.Abstract;
using MyWebsite.Core.Utilities.Results.ComplexTypes;
using MyWebsite.Entities.ComplexTypes;
using MyWebsite.Entities.Concrete;
using MyWebsite.Entities.Dtos;
using MyWebsite.Entities.Enums;
using MyWebsite.Mvc.Helpers.Abstract;
using MyWebsite.MvcUI.Areas.Admin.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebsite.MvcUI.Areas.Admin.Controllers
{
    [Area("WNqGRjUh3JPe")]
    [Authorize(Roles = "Admin,SuperAdmin,Developer")]
    public class NewsController : BaseController
    {
        INewsService _newsService;
        ICategoryService _categoryService;      

        public NewsController(INewsService newsService, ICategoryService categoryService, UserManager<User> userManager, IMapper mapper, IImageHelper imageHelper) : base(userManager, mapper, imageHelper)
        {
            _newsService = newsService;
            _categoryService = categoryService;           
        }

        public IActionResult Index()
        {            
            var news = _newsService.GetAllByNonDeleted();
            return View(news);
        }

        //public IActionResult GetAllNews()
        //{
        //    var news = _newsService.GetAll();
        //    var newsJson = JsonConvert.SerializeObject(news);
        //    return Json(newsJson);
        //}
                
        [HttpGet]
        public IActionResult AddNews()
        {
            var categories = _categoryService.GetAllByNonDeleted().Where(x=>x.CategoryType == Convert.ToInt32(CategoryType.Haber)).ToList();
            return View(new NewsAddViewModel { 
            Categories= categories
            });
        }
                
        [HttpPost]
        public async Task<IActionResult> AddNews(NewsAddViewModel newsAddViewModel )
        {
            if (ModelState.IsValid)
            {
                var news = Mapper.Map<News>(newsAddViewModel);
                news.CreatedDate = DateTime.Now;
                news.UserId = LoggedInUser.Id;
                var imageResult = await ImageHelper.Upload(newsAddViewModel.Title,
                      newsAddViewModel.ThumbnailFile, PictureType.Post);
                news.Thumbnail = imageResult.Data.FullName;
                _newsService.Add(news);
                return RedirectToAction("Index");
            }
            else
            {
                var categories = _categoryService.GetAllByNonDeleted().Where(x => x.CategoryType == Convert.ToInt32(CategoryType.Haber)).ToList();
                newsAddViewModel.Categories = categories;
                return View(newsAddViewModel);
            }
         
        }

        [HttpPost]
        public IActionResult DeleteNews(int id)
        {
            var news = _newsService.Get(x=>x.Id==id);
            ImageHelper.Delete(news.Thumbnail);
            news.IsDeleted = true;
            news.IsActive = false;
             var jsonNews = JsonConvert.SerializeObject(news);
            _newsService.Update(news);
          

            return Json(jsonNews);
         
        }

        public IActionResult ChangeStatus(int id)
        {
            var news = _newsService.Get(x => x.Id == id);
            var category = _categoryService.Get(x => x.Id == news.CategoryId);
            news.Category = category;
            news.IsActive = news.IsActive == true ? false : true;
            var jsonNews = JsonConvert.SerializeObject(news);
            _newsService.Update(news);

            return Json(jsonNews);
        } 

        [HttpGet]
        public IActionResult UpdateNews(int id)
        {
            var categories = _categoryService.GetAllByNonDeleted().Where(x => x.CategoryType == Convert.ToInt32(CategoryType.Haber)).ToList();
            var news = _newsService.Get(x => x.Id==id);
            var newsUpdateDto = Mapper.Map<NewsUpdateDto>(news);
            newsUpdateDto.Categories = categories;
            return View(newsUpdateDto);
        }

        public IActionResult UpdateNews(NewsUpdateDto newsUpdateDto)
        {
            if(ModelState.IsValid)
            {
                bool isNewPictureUploaded = false;
                var oldnews = _newsService.Get(x => x.Id == newsUpdateDto.Id);

                var oldNewsPicture = oldnews.Thumbnail;
                if (newsUpdateDto.ThumbnailFile != null)
                {
                    var uploadedImageResult = ImageHelper.Upload(newsUpdateDto.Title,
                      newsUpdateDto.ThumbnailFile, PictureType.Post).Result;
                    newsUpdateDto.Thumbnail = uploadedImageResult.Data.FullName;

                    isNewPictureUploaded = true;
                }

                if (isNewPictureUploaded)
                {
                    ImageHelper.Delete(oldNewsPicture);
                }

                var news = Mapper.Map<News>(newsUpdateDto);
                news.UserId = LoggedInUser.Id;
                _newsService.Update(news);

                return RedirectToAction("Index");

            }

            else
            {
                var categories = _categoryService.GetAllByNonDeleted().Where(x => x.CategoryType == Convert.ToInt32(CategoryType.Haber)).ToList();
                newsUpdateDto.Categories = categories;
                foreach (var modelState in ViewData.ModelState.Values)
                {
                    foreach (var error in modelState.Errors)
                    {
                        ModelState.AddModelError("", error.ErrorMessage);
                    }
                }
                return View(newsUpdateDto);
            }
        
        }
    }
}
