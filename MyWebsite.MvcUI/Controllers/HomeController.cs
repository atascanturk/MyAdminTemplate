using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyWebsite.Business.Abstract;
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
        private readonly ILogger<HomeController> _logger;
        IMaintenanceCheckService _maintenanceCheckService;        

        public HomeController(ILogger<HomeController> logger, IMaintenanceCheckService maintenanceCheckService)
        {
            _logger = logger;
            _maintenanceCheckService = maintenanceCheckService;
        }

        public IActionResult Index()
        {
            
            var check = _maintenanceCheckService.Get(x => x.Id == 1);
            if (check.IsUnderMaintenance == true)
            {
                if (check.EndTime > DateTime.Now)
                {
                    return View("ComingSoonIndex", new MaintenanceTimeViewModel { EndTime = check.EndTime });                   
                }

                else
                {
                    check.IsUnderMaintenance = false;
                    check.EndTime = DateTime.Now;
                    _maintenanceCheckService.Update(check);
                    return View();
                }
               
            } 
            
          return  View();

        }

        public IActionResult ComingSoonIndex(MaintenanceTimeViewModel maintenanceTimeViewModel)
        {
            return View(maintenanceTimeViewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
