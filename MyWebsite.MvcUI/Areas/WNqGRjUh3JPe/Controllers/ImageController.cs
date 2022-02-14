using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyWebsite.Business.Abstract;
using MyWebsite.Core.Utilities.Extensions;
using MyWebsite.Core.Utilities.Results.ComplexTypes;
using MyWebsite.Entities.ComplexTypes;
using MyWebsite.Entities.Concrete;
using MyWebsite.Entities.Dtos;
using MyWebsite.Entities.Enums;
using MyWebsite.Mvc.Helpers.Abstract;
using MyWebsite.MvcUI.Areas.WNqGRjUh3JPe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace MyWebsite.MvcUI.Areas.WNqGRjUh3JPe.Controllers
{
    [Area("WNqGRjUh3JPe")]
    [Authorize(Roles = "Admin,SuperAdmin,Developer")]
    public class ImageController : Controller
    {
        IImageService _imageService;
        ICategoryService _categoryService;
        IImageHelper _imageHelper;
        IMapper _mapper;

        public ImageController(IImageService imageService, IImageHelper imageHelper, IMapper mapper, ICategoryService categoryService)
        {
            _imageService = imageService;
            _imageHelper = imageHelper;
            _mapper = mapper;
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
           var images = _imageService.GetAllByNonDeleted();
            var imageIndexViewModels = new List<ImageIndexViewModel>();
            foreach (var image in images)
            {
                imageIndexViewModels.Add(new ImageIndexViewModel { Id= image.Id, Path=image.Path,Category = image.Category});
            }
            
            return View(imageIndexViewModels);
        }

        [HttpGet]
        public IActionResult AddImage()
        {
            var categories = _categoryService.GetAllByNonDeleted().Where(x => x.CategoryType == Convert.ToInt32(CategoryType.Resim)).ToList();
            return PartialView("_ImageAddPartial",new ImageEntityAddDto
            {
                Categories = categories
            });
           
        }

        [HttpPost]
        public IActionResult AddImage(ImageEntityAddDto imageEntityAddDto)
        {
            if (ModelState.IsValid)
            {
                var imageResult = _imageHelper.Upload("Image-", imageEntityAddDto.PictureFile, PictureType.Photograph, "Photograph").Result;
                imageEntityAddDto.Picture = imageResult.Data.FullName;
               var category = _categoryService.Get(x => x.Id == imageEntityAddDto.CategoryId);
                var image = new Image { Path = imageResult.Data.FullName,CategoryId=imageEntityAddDto.CategoryId,Category = category };
                _imageService.Add(image);
                imageEntityAddDto.Categories = _categoryService.GetAllByNonDeleted().Where(x => x.CategoryType == Convert.ToInt32(CategoryType.Resim)).ToList();
                var imageAddAjaxViewModel = JsonSerializer.Serialize(new ImageAddAjaxViewModel
                {
                    ImageDto = new ImageEntityDto
                    {
                        ResultStatus = ResultStatus.Success,
                        Message = $"Seçilen resim başarıyla eklenmiştir.",
                        Image = image
                    },
                    ImageAddPartial = this.RenderViewToStringAsync("_ImageAddPartial", imageEntityAddDto).Result

                });
               
                return Json(imageAddAjaxViewModel);

            }

            else
            {
                foreach (var modelState in ViewData.ModelState.Values)
                {
                    foreach (var error in modelState.Errors)
                    {
                        ModelState.AddModelError("", error.ErrorMessage);
                    }
                }
                var categories = _categoryService.GetAllByNonDeleted().Where(x => x.CategoryType == Convert.ToInt32(CategoryType.Resim)).ToList();
                imageEntityAddDto.Categories = categories;
                var imageAddAjaxErrorModel = JsonSerializer.Serialize(new ImageAddAjaxViewModel
                {
                    ImageAddDto = imageEntityAddDto,
                    ImageAddPartial = this.RenderViewToStringAsync("_ImageAddPartial", imageEntityAddDto).Result
                });
                return Json(imageAddAjaxErrorModel);
            }
            
        }

        [HttpPost]
        public IActionResult DeleteImage(int id)
        {
            var image = _imageService.Get(x => x.Id == id);
            image.IsDeleted = true;
            _imageHelper.Delete(image.Path);
            var jsonImage = JsonSerializer.Serialize(image);
            _imageService.Update(image);


            return Json(jsonImage);

        }
    }
}
