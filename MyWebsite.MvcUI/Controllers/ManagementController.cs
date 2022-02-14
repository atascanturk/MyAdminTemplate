using Microsoft.AspNetCore.Mvc;
using MyWebsite.Business.Abstract;
using MyWebsite.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebsite.MvcUI.Controllers
{
    public class ManagementController : Controller
    {
        IAdministrativeStaffService _administrativeStaffService;

        public ManagementController(IAdministrativeStaffService administrativeStaffService)
        {
            _administrativeStaffService = administrativeStaffService;
        }

        [HttpGet("Yonetim")]
        public IActionResult Index()
        {
            var administrativeStaff = _administrativeStaffService.GetAllByNonDeleted().Where(x => x.Category.Name == "Başkanlık Divanı").ToList();
            return View(administrativeStaff);
        }

        [HttpGet("BaskanlikDivani")]
        public IActionResult Administration()
        {
            var administrativeStaff = _administrativeStaffService.GetAllByNonDeleted().Where(x => x.Category.Name == "Başkanlık Divanı").ToList();
            return View(administrativeStaff);
        }

        [HttpGet("MKYKUyeleri")]
        public IActionResult MKYKMembers()
        {
            var administrativeStaff = _administrativeStaffService.GetAllByNonDeleted().Where(x => x.Category.Name == "MKYK Üyeleri").ToList();
            return View(administrativeStaff);
        }

        [HttpGet("MDKUyeleri")]
        public IActionResult MDKMembers()
        {
            var administrativeStaff = _administrativeStaffService.GetAllByNonDeleted().Where(x => x.Category.Name == "MDK Üyeleri").ToList();
            return View(administrativeStaff);
        }

        [HttpGet("YuksekDanismaKurulu")]
        public IActionResult HighAdvisoryBoard()
        {
            var administrativeStaff = _administrativeStaffService.GetAllByNonDeleted().Where(x => x.Category.Name == "Yüksek Danışma Kurulu").ToList();
            return View(administrativeStaff);
        }

        [HttpGet("OzelKalem")]
        public IActionResult ExecutiveAsistant()
        {
            var administrativeStaff = _administrativeStaffService.GetAllByNonDeleted().Where(x => x.Category.Name == "Özel Kalem").ToList();
            return View(administrativeStaff);
        }


        public IActionResult Get(int id)
        {
            var administrativeStaff = _administrativeStaffService.Get(x => x.Id == id & !x.IsDeleted);

            return View(administrativeStaff);
        }
    }
}
