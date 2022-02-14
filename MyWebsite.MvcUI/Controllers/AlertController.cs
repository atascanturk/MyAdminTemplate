using Microsoft.AspNetCore.Mvc;
using MyWebsite.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebsite.MvcUI.Controllers
{
    public class AlertController : Controller
    {
        IAlertService _alertService;

        public AlertController(IAlertService alertService)
        {
            _alertService = alertService;
        }

        public IActionResult GetAlert()
        {
          var alert =  _alertService.GetAllByNonDeleted().FirstOrDefault();

            if (alert != null)
            {
                return PartialView("_AlertPartial",alert);
            }

            return Json("");

            // var alertJson =  this.RenderViewToStringAsync("_AlertPartial", alert).Result;
            //return Json(alertJson);
        }
    }
}
