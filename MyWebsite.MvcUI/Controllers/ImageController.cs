using Microsoft.AspNetCore.Mvc;
using MyWebsite.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebsite.MvcUI.Controllers
{
    public class ImageController : Controller
    {
        IImageService _imageService;

        public ImageController(IImageService imageService)
        {
            _imageService = imageService;
        }

        [HttpGet("Galeri")]
        public IActionResult Galery()        {
           
            return View();
        }

        public IActionResult MuhsinYaziciogluImages()
        {
            var images = _imageService.GetAllByNonDeleted().Where(x=>x.Category.Name == "Muhsin YAZICIOĞLU Resimleri").ToList();
            return View(images);
        }

        public IActionResult MustafaDesticiImages()
        {
            var images = _imageService.GetAllByNonDeleted().Where(x => x.Category.Name == "Mustafa DESTİCİ Resimleri").ToList();
            return View(images);
        }
    }
}
