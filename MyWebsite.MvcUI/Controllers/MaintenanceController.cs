using Microsoft.AspNetCore.Mvc;
using MyWebsite.Business.Abstract;
using MyWebsite.MvcUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebsite.MvcUI.Controllers
{
    public class MaintenanceController : Controller
    {
        IMaintenanceCheckService _maintenanceCheckService;

        public MaintenanceController(IMaintenanceCheckService maintenanceCheckService)
        {
            _maintenanceCheckService = maintenanceCheckService;
        }

        public IActionResult ComingSoonIndex()
        {
            var check = _maintenanceCheckService.Get(x => x.Id == 1);
            if (check.IsUnderMaintenance == true)
            {
                if (check.EndTime > DateTime.Now)
                {
                    return View("ComingSoonIndex" , new MaintenanceTimeViewModel { EndTime = check.EndTime });
                }          

            }

            return NotFound();

        }
    }
}
