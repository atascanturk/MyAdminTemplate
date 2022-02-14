using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyWebsite.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace MyWebsite.MvcUI.Areas.WNqGRjUh3JPe.Controllers
{
    [Area("WNqGRjUh3JPe")]
    [Authorize(Roles = "Admin,SuperAdmin,Developer")]
    public class BulletinController : Controller
    {
        IBulletinService _bulletinService;

        public BulletinController(IBulletinService bulletinService)
        {
            _bulletinService = bulletinService;
        }

        public IActionResult Index()
        {
            var bulletins = _bulletinService.GetAllByNonDeleted();
            return View(bulletins);
        }

        public IActionResult Delete(int id)
        {
            var bulletin = _bulletinService.Get(x => x.Id == id);
            bulletin.IsDeleted = true;
            _bulletinService.Update(bulletin);
            var jsonBulletin = JsonSerializer.Serialize(bulletin);
            return Json(jsonBulletin);
        }
    }
}
