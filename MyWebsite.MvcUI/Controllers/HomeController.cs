using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyWebsite.Business.Abstract;
using MyWebsite.Core.Utilities.Security.Captcha.Google;
using MyWebsite.MvcUI.Models;
using Serilog;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebsite.MvcUI.Controllers
{
    public class HomeController : Controller
    {      

        public IActionResult Index()
        {           
                     
          return  View();

        }      

    }
}
