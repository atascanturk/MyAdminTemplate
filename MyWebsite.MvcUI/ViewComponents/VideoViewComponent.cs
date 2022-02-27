using Microsoft.AspNetCore.Mvc;
using MyWebsite.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebsite.MvcUI.ViewComponents
{
    public class VideoViewComponent :ViewComponent
    {
        IVideoService _videoService;

        public VideoViewComponent(IVideoService videoService)
        {
            _videoService = videoService;
        }

        public IViewComponentResult Invoke()
        {
            var video = _videoService.GetAllByNonDeleted();

            return View(video);
        }
    }
}
