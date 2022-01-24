using Microsoft.Extensions.Configuration;
using MyWebsite.Core.Entities.Concrete;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MyWebsite.Core.Utilities.Security.Captcha.Google
{
    public class RecaptchaValidator : IRecaptchaValidator
    {
        public readonly IConfiguration Configuration;
        private const string GoogleRecaptchaAddress = "https://www.google.com/recaptcha/api/siteverify";       

        public RecaptchaValidator(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public bool IsRecaptchaValid(string token)
        {
            using var client = new HttpClient();
            var response = client.GetStringAsync($@"{GoogleRecaptchaAddress}?secret={Configuration["GoogleReCaptcha:SecretKey"]}&response={token}").Result;
            var recaptchaResponse = JsonConvert.DeserializeObject<TokenResponse>(response);

            if (!recaptchaResponse.Success)
            {
                return false;
            }
            return true;
        }

        public bool IsRecaptchaV3Valid(string token)
        {
            using var client = new HttpClient();
            var response = client.GetStringAsync($@"{GoogleRecaptchaAddress}?secret={Configuration["GoogleReCaptcha:SecretKeyV3"]}&response={token}").Result;
            var recaptchaResponse = JsonConvert.DeserializeObject<TokenResponse>(response);

            if (!recaptchaResponse.Success || recaptchaResponse.Score < Convert.ToDecimal(0.9))
            {
                return false;
            }
            return true;
        }
    }
}
