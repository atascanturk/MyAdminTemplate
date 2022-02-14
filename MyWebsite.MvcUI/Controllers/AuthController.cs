using Microsoft.AspNetCore.Mvc;
using MyWebsite.Core.Utilities.Security.Captcha.Google;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebsite.MvcUI.Controllers
{
    public class AuthController : Controller
    {
        private readonly IRecaptchaValidator _recaptchaValidator;

        public AuthController(IRecaptchaValidator recaptchaValidator)
        {
            _recaptchaValidator = recaptchaValidator;
        }

        [HttpGet]
        public JsonResult RecaptchaVerifyV3(string token)
        {
            bool isValid = _recaptchaValidator.IsRecaptchaV3Valid(token);

            return Json(isValid);
        }
    }
}
