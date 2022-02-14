using Microsoft.AspNetCore.Mvc;
using MyWebsite.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebsite.MvcUI.ViewComponents
{
    public class ImageViewComponent :ViewComponent
    {
        IImageService _imageService;

        public ImageViewComponent(IImageService imageService)
        {
            _imageService = imageService;
        }

        public IViewComponentResult Invoke()
        {
          var images =  _imageService.GetAllByNonDeleted();
            return View(images);
        }
    }
}
