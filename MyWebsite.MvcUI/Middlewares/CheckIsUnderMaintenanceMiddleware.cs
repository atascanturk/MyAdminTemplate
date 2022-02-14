using Microsoft.AspNetCore.Http;
using MyWebsite.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebsite.MvcUI.Middlewares
{
    public class CheckIsUnderMaintenanceMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly IMaintenanceCheckService _maintenanceCheckService;

        public CheckIsUnderMaintenanceMiddleware(RequestDelegate next, IMaintenanceCheckService maintenanceCheckService)
        {
            _next = next;
            _maintenanceCheckService = maintenanceCheckService;
        }

        public async Task Invoke(HttpContext context)
        {
            if (!context.Request.Path.ToString().Contains("/Maintenance"))
            {
                var status = CheckIfIsUnderMaintenance();
                if (status == true)
                {
                    if (!context.Request.Path.ToString().Contains("/WNqGRjUh3JPe"))
                    {

                        context.Request.Path="/Maintenance/ComingSoonIndex";
                    }
                }
            }

            await _next.Invoke(context);
        }


        private bool CheckIfIsUnderMaintenance()
        {
            var check = _maintenanceCheckService.Get(x => x.Id == 1);

            if (check.EndTime < DateTime.Now)
            {
                check.IsUnderMaintenance = false;
                check.EndTime = DateTime.Now;
                _maintenanceCheckService.Update(check);

            }

            if (check.IsUnderMaintenance == true)
            {
                return true;
            }

            return false;
        }
    }
}
