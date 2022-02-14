using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebsite.MvcUI.Controllers
{
    public class FileController : Controller
    {
        [HttpGet("Dosyalar")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
