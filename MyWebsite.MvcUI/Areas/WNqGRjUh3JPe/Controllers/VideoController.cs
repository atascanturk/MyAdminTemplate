using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyWebsite.Business.Abstract;
using MyWebsite.Core.Utilities.Extensions;
using MyWebsite.Core.Utilities.Results.ComplexTypes;
using MyWebsite.Entities.Concrete;
using MyWebsite.Entities.Dtos;
using MyWebsite.MvcUI.Areas.WNqGRjUh3JPe.Models;

namespace MyWebsite.MvcUI.Areas.WNqGRjUh3JPe.Controllers
{
    [Area("WNqGRjUh3JPe")]
    [Authorize(Roles = "Admin,SuperAdmin,Developer")]
    public class VideoController : Controller
    {
        IVideoService _videoService;
        IMapper _mapper;

        public VideoController(IVideoService videoService, IMapper mapper)
        {
            _videoService = videoService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var videos = _videoService.GetAllByNonDeleted();
            return View(videos);
        }

        [HttpGet]
        public IActionResult AddVideo()
        {
            return PartialView("_VideoAddPartial");
        }


        [HttpPost]
        public IActionResult AddVideo(VideoAddDto videoAddDto)
        {
            if (ModelState.IsValid)
            {
                var video = _mapper.Map<Video>(videoAddDto);
                _videoService.Add(video);

                var videoAddAjaxViewModel = JsonSerializer.Serialize(new VideoAddAjaxViewModel
                {
                    VideoDto = new VideoDto
                    {
                        ResultStatus = ResultStatus.Success,
                        Message = $"Seçilen video başarıyla eklenmiştir.",
                        Video = video
                    },
                    VideoAddPartial = this.RenderViewToStringAsync("_VideoAddPartial", videoAddDto).Result

                });

                return Json(videoAddAjaxViewModel);

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

                var videoAddAjaxErrorModel = JsonSerializer.Serialize(new VideoAddAjaxViewModel
                {
                    VideoAddDto = videoAddDto,
                    VideoAddPartial = this.RenderViewToStringAsync("_VideoAddPartial", videoAddDto).Result
                });
                return Json(videoAddAjaxErrorModel);
            }
        }

        [HttpPost]
        public IActionResult DeleteVideo(int id)
        {
            var video = _videoService.Get(x => x.Id == id);
            video.IsDeleted = true;          
            var jsonVideo = JsonSerializer.Serialize(video);
            _videoService.Update(video);


            return Json(jsonVideo);

        }

    }
}
