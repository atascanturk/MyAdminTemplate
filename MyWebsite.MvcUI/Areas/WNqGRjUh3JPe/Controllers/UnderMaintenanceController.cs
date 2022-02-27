using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using MyWebsite.Business.Abstract;
using MyWebsite.Entities.Concrete;
using MyWebsite.Entities.Dtos;
using Newtonsoft.Json;

namespace MyWebsite.MvcUI.Areas.WNqGRjUh3JPe.Controllers
{
    [Area("WNqGRjUh3JPe")]
    [Authorize(Roles = "SuperAdmin,Developer")]
    public class UnderMaintenanceController : Controller
    {
        readonly IMaintenanceCheckService _maintenanceCheckService;
        readonly IMailService _mailService;
        EmailSendDto _emailSendDto;

        public UnderMaintenanceController(IMaintenanceCheckService maintenanceCheckService, IMailService mailService, IOptions<EmailSendDto> emailSendDto)
        {
            _maintenanceCheckService = maintenanceCheckService;
            _mailService = mailService;
            _emailSendDto = emailSendDto.Value;
        }

        public IActionResult Index()
        {
            var result = _maintenanceCheckService.Get(x => x.Id == 1);
            return View(result);
        }

        [HttpGet]
        public IActionResult ChangeStatus()
        {
            var result = _maintenanceCheckService.Get(x => x.Id == 1);
            result.IsUnderMaintenance = result.IsUnderMaintenance == true ? false : true;
            _maintenanceCheckService.Update(result);
            var resultJson = JsonConvert.SerializeObject(result);
            return Json(resultJson);
        }
        [HttpPost]
        public IActionResult ChangeStatus(MaintenanceCheck maintenanceCheck)
        {
            if (ModelState.IsValid)
            {
                if (maintenanceCheck.EndTime < DateTime.Now)
                {
                    maintenanceCheck.EndTime = DateTime.Now.AddDays(1);
                }
                var result = _maintenanceCheckService.Get(x => x.Id == 1);
                result.IsUnderMaintenance = result.IsUnderMaintenance == true ? false : true;
                result.EndTime = result.IsUnderMaintenance == true ? maintenanceCheck.EndTime : DateTime.Now;

                _maintenanceCheckService.Update(result);
                var resultJson = JsonConvert.SerializeObject(result);
                return Json(resultJson);
            }

            else
            {
                return View(maintenanceCheck);
            }


        }

        public IActionResult SendTestEmailToAllUsers()
        {
            _emailSendDto.Email = "";
            _emailSendDto.Subject = "Test Mail";
            _emailSendDto.Message = "Bu bir test mailidir. Lütfen dikkate almayınız.";
            _mailService.Send(_emailSendDto);
            return Json("");
        }
    }
}
