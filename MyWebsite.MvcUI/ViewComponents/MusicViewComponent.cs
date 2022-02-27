using Microsoft.AspNetCore.Mvc;
using MyWebsite.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebsite.MvcUI.ViewComponents
{
    public class MusicViewComponent :ViewComponent
    {
        IMusicService _musicService;

        public MusicViewComponent(IMusicService musicService)
        {
            _musicService = musicService;
        }

        public IViewComponentResult Invoke()
        {
            var music = _musicService.GetAllByNonDeleted();

            return View(music);
        }
    }
}
