using Microsoft.AspNetCore.Http;
using MyWebsite.Business.Abstract;
using MyWebsite.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebsite.MvcUI.Middlewares
{
    public class SetSEOMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ISeoService _seoService;

        public SetSEOMiddleware(RequestDelegate next, ISeoService seoService)
        {
            _next = next;
            _seoService = seoService;
        }

        public async Task Invoke(HttpContext context)
        {            
          var seo =  _seoService.Get(x => x.Id == 1);
                       
                GlobalProperties.SeoAuthor = seo.SeoAuthor;
                GlobalProperties.SeoDesc = seo.SeoDescription;
                GlobalProperties.SeoTags = seo.SeoTags;         

            await _next.Invoke(context);
        }

    }
}
