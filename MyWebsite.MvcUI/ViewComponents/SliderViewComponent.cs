using Microsoft.AspNetCore.Mvc;
using MyWebsite.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebsite.MvcUI.ViewComponents
{
    public class SliderViewComponent : ViewComponent
    {
        ISliderService _sliderService;

        public SliderViewComponent(ISliderService sliderService)
        {
            _sliderService = sliderService;
        }

        public IViewComponentResult Invoke()
        {
            var sliders = _sliderService.GetAllByNonDeleted().OrderByDescending(x=>x.Id).ToList();
            return View(sliders);
        }
    }
}
