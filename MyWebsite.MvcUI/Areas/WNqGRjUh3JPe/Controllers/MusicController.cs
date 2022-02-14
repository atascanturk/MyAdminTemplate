using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyWebsite.Business.Abstract;
using MyWebsite.Core.Utilities.Results.ComplexTypes;
using MyWebsite.Entities.Concrete;
using MyWebsite.Mvc.Helpers.Abstract;
using MyWebsite.MvcUI.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace MyWebsite.MvcUI.Areas.Admin.Controllers
{
    [Area("WNqGRjUh3JPe")]
    [Authorize(Roles = "Admin,SuperAdmin,Developer")]
    public class MusicController : Controller
    {
        IMusicService _musicService;
        IMapper _mapper;
        IMusicHelper _musicHelper;

        public MusicController(IMusicService musicService, IMapper mapper, IMusicHelper musicHelper)
        {
            _musicService = musicService;
            _mapper = mapper;
            _musicHelper = musicHelper;
        }

        public IActionResult Index()
        {
            var musics = _musicService.GetAllByNonDeleted();
            return View(musics);
        }

        [HttpGet]
        public IActionResult AddMusic()        {
           
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddMusic(MusicAddViewModel musicAddViewModel)
        {
            if (ModelState.IsValid)
            {
                var musicResult = await _musicHelper.Upload("Music", musicAddViewModel.MusicFile);
                if (musicResult.ResultStatus == ResultStatus.Success)
                {
                    var music = _mapper.Map<Music>(musicAddViewModel);
                   
                    music.Path = musicResult.Data.FullName;
                    _musicService.Add(music);

                    return RedirectToAction("Index", "Music");
                }
                else
                {
                    ModelState.AddModelError("", "Lütfen mp3 uzantılı bir müzik dosyası seçiniz.");
                    return View("AddMusic");
                }
            }

            return View();
          
        }

        [HttpPost]
        public IActionResult DeleteMusic(int id)
        {
            var music = _musicService.Get(x => x.Id == id);
            music.IsDeleted = true;
            _musicHelper.Delete(music.Path);
            var jsonMusic = JsonSerializer.Serialize(music);
            _musicService.Update(music);


            return Json(jsonMusic);

        }
    }
}
