using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyWebsite.Core.Utilities.Security.Captcha.Google;
using MyWebsite.Entities.Concrete;
using MyWebsite.Entities.Dtos;
using MyWebsite.MvcUI.Areas.WNqGRjUh3JPe.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebsite.MvcUI.Areas.Admin.Controllers
{
    [Area("WNqGRjUh3JPe")]
    public class AuthController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        IRecaptchaValidator _recaptchaValidator;


        public AuthController(UserManager<User> userManager, SignInManager<User> signInManager, IRecaptchaValidator recaptchaValidator)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _recaptchaValidator = recaptchaValidator;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(UserLoginDto userLoginDto)
        {
            if (ModelState.IsValid)
            {
                var token = HttpContext.Request.Form["g-recaptcha-response"];
                bool isValid = _recaptchaValidator.IsRecaptchaValid(token);

                if (!isValid)
                {
                    ModelState.AddModelError("", "Doğrulama Başarısız.");
                    return View("Login");
                }

                var user = await _userManager.FindByEmailAsync(userLoginDto.Email);
                if (user != null)
                {
                    var result = await _signInManager.PasswordSignInAsync(user, userLoginDto.Password,
                        userLoginDto.RememberMe, false);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        ModelState.AddModelError("", "E-posta adresiniz veya şifreniz yanlıştır.");
                        return View("Login");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "E-posta adresiniz veya şifreniz yanlıştır.");
                    return View("Login");
                }
            }
            else
            {
                return View();
            }

        }

        [Authorize]
        [HttpGet]
        public ViewResult AccessDenied()
        {
            return View();
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home", new { Area = "" });
        }



        [HttpGet]
        public JsonResult RecaptchaVerify(string token)
        {
           bool isValid = _recaptchaValidator.IsRecaptchaValid(token);

            return Json(isValid);
        }

        [HttpGet]
        public JsonResult RecaptchaVerifyV3(string token)
        {
            bool isValid = _recaptchaValidator.IsRecaptchaV3Valid(token);

            return Json(isValid);
        }
    }
}
