using Microsoft.AspNetCore.Mvc;
using MyWebsite.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebsite.MvcUI.Controllers
{
    public class MusicController : Controller
    {
        IMusicService _musicService;

        public MusicController(IMusicService musicService)
        {
            _musicService = musicService;
        }

        [HttpGet("Muzik")]
        public IActionResult Index()
        {
            var musics = _musicService.GetAllByNonDeleted();
            return View(musics);
        }
    }
}
