using Microsoft.AspNetCore.Http;
using MyWebsite.Business.Abstract;
using MyWebsite.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebsite.MvcUI.Middlewares
{
    public class VisitorCounterMiddleware
    {
        private readonly RequestDelegate _next;
        IVisitorCountService _visitorCountService;

        public VisitorCounterMiddleware(RequestDelegate next, IVisitorCountService visitorCountService)
        {
            _next = next;
            _visitorCountService = visitorCountService;
        }

        public async Task Invoke(HttpContext context)
        {
            string visitorId = context.Request.Cookies["VisitorId"];
            if (visitorId == null)
            {
                UpdateVisitorCounter();

                context.Response.Cookies.Append("VisitorId", Guid.NewGuid().ToString(), new CookieOptions()
                {
                    Path = "/",
                    HttpOnly = true,
                    Secure = false,
                    Expires = DateTime.Now.AddDays(30 - DateTime.Now.Day) // Expire time will be till the end of the month.
                });
            }

            await _next.Invoke(context);
        }


        private void UpdateVisitorCounter()
        {
            // A new count record will be created if there is no record for that month and year.
            if (!_visitorCountService.GetAll(x => x.Month == DateTime.Now.Month && x.Year == DateTime.Now.Year).Any())
            {
                VisitorCount newVisitorCount = new VisitorCount();
                newVisitorCount.Count = 1;
                newVisitorCount.Month = DateTime.Now.Month;
                newVisitorCount.Year = DateTime.Now.Year;
                _visitorCountService.Add(newVisitorCount);

            }
            else
            {
                var visitorCount = _visitorCountService.Get(x => x.Month == DateTime.Now.Month && x.Year == DateTime.Now.Year);
                visitorCount.Count += 1;
                _visitorCountService.Update(visitorCount);
            }


        }
    }
}
