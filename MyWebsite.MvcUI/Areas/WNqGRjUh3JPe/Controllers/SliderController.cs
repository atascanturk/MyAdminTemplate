using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyWebsite.Business.Abstract;
using MyWebsite.Entities.ComplexTypes;
using MyWebsite.Entities.Concrete;
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
    public class SliderController : Controller
    {
        readonly ISliderService _sliderService;
        readonly IImageHelper _imageHelper;
        readonly IMapper _mapper;

        public SliderController(ISliderService sliderService, IImageHelper imageHelper, IMapper mapper)
        {
            _sliderService = sliderService;
            _imageHelper = imageHelper;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var sliders = _sliderService.GetAllByNonDeleted().OrderByDescending(x=>x.Id).ToList();
            return View(sliders);
        }

        [HttpGet]
        public IActionResult AddSlider()
        {           
            return View();
        }

        [HttpPost]
        public async Task <IActionResult> AddSlider(SliderAddViewModel sliderAddViewModel)
        {
            var imageResult = await _imageHelper.Upload("Slider-",sliderAddViewModel.SliderPic, PictureType.Slider,"sliderImages");
            var slider = _mapper.Map<Slider>(sliderAddViewModel);
            slider.Path = imageResult.Data.FullName;
            _sliderService.Add(slider);
            return RedirectToAction("Index","Slider", new { Area = "WNqGRjUh3JPe" });
        }

        [HttpPost]
        public IActionResult DeleteSlider(int id)
        {
            var slider = _sliderService.Get(x => x.Id == id);
            slider.IsDeleted = true;
            _imageHelper.Delete(slider.Path);
            var jsonSlider = JsonConvert.SerializeObject(slider);
            _sliderService.Update(slider);


            return Json(jsonSlider);

        }
    }
}
