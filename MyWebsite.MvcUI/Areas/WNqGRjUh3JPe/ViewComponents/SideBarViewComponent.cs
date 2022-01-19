using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyWebsite.Entities.Concrete;
using MyWebsite.MvcUI.Areas.WNqGRjUh3JPe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebsite.MvcUI.Areas.ViewComponents
{
    public class SideBarViewComponent : ViewComponent
    {
        private readonly UserManager<User> _userManager;

        public SideBarViewComponent(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        public IViewComponentResult Invoke()
        {
            var user = _userManager.GetUserAsync(HttpContext.User).Result;
            var roles =  _userManager.GetRolesAsync(user).Result;
            if (roles == null)
            {
                return Content("Roller Bulunamadı.");
            }
            return View(new UserWithRolesViewModel
            {
                User = user,
                Roles = roles
            });
        }
    }
}
