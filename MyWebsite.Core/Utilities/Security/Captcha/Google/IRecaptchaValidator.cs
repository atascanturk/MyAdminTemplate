using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebsite.Core.Utilities.Security.Captcha.Google
{
   public interface IRecaptchaValidator
    {
        bool IsRecaptchaValid(string token);
        bool IsRecaptchaV3Valid(string token);
    }
}
