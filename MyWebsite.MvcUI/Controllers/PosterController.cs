using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebsite.MvcUI.Controllers
{
    public class PosterController : Controller
    {
        [HttpGet("Afisler")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
