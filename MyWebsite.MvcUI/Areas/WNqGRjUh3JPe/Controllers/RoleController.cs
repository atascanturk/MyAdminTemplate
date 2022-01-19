using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyWebsite.Core.Utilities.Extensions;
using MyWebsite.Core.Utilities.Results.ComplexTypes;
using MyWebsite.Entities.Concrete;
using MyWebsite.Entities.Dtos;
using MyWebsite.Mvc.Helpers.Abstract;
using MyWebsite.MvcUI.Areas.Admin.Controllers;
using MyWebsite.MvcUI.Areas.WNqGRjUh3JPe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace MyWebsite.MvcUI.Areas.WNqGRjUh3JPe.Controllers
{
    [Area("WNqGRjUh3JPe")]
    [Authorize(Roles ="Developer")]
    public class RoleController : BaseController
    {
        private readonly RoleManager<Role> _roleManager;

        public RoleController(RoleManager<Role> roleManager, UserManager<User> userManager, IMapper mapper, IImageHelper imageHelper) : base(userManager, mapper, imageHelper)
        {
            _roleManager = roleManager;
        }
        public IActionResult Index()
        {
            var roles = _roleManager.Roles.ToList();
            return View(new RoleListDto
            {
                Roles = roles
            }); ;
        }

        [HttpGet]
        public IActionResult GetAllRoles()
        {
            var roles = _roleManager.Roles.ToList();
            var roleListDto = JsonSerializer.Serialize(new RoleListDto
            {
                Roles = roles
            });

            return Json(roleListDto);


        }

        [HttpGet]
        public async Task<IActionResult> Assign(int userId)
        {

            var roles = _roleManager.Roles.ToList();
            var user = UserManager.Users.SingleOrDefault(u => u.Id == userId);
            var userRoles = await UserManager.GetRolesAsync(user);

            UserRoleAssignDto userRoleAssignDto = new()
            {
                UserId = user.Id,
                UserName = user.UserName
            };
            foreach (var role in roles)
            {
                RoleAssignDto roleAssignDto = new()
                {
                    RoleId = role.Id,
                    RoleName = role.Name,
                    HasRole = userRoles.Contains(role.Name)
                };

                userRoleAssignDto.RoleAssignDtos.Add(roleAssignDto);
            }

            return PartialView("_RoleAssignPartial", userRoleAssignDto);

        }

        
        [HttpPost]
        public async Task<IActionResult> Assign(UserRoleAssignDto userRoleAssignDto)
        {
            if (ModelState.IsValid)
            {
                var user = UserManager.Users.SingleOrDefault(u => u.Id == userRoleAssignDto.UserId);

                foreach (var roleAssignDto in userRoleAssignDto.RoleAssignDtos)
                {
                    if (roleAssignDto.HasRole)
                    {
                        await UserManager.AddToRoleAsync(user, roleAssignDto.RoleName);
                    }

                    else
                    {
                        await UserManager.RemoveFromRoleAsync(user, roleAssignDto.RoleName);
                    }
                }
                await UserManager.UpdateSecurityStampAsync(user);

                var userRoleAssignAjaxViewModel = JsonSerializer.Serialize(new UserRoleAssignAjaxViewModel
                {
                    UserDto = new UserDto
                    {
                        User = user,
                        Message = $"{user.UserName} kullanıcısına ait rol atama işlemi başarıyla tamamlanmıştır.",
                        ResultStatus = ResultStatus.Success
                    },
                    RoleAssignPartial = await this.RenderViewToStringAsync("_RoleAssignPartial", userRoleAssignDto)

                });

                return Json(userRoleAssignAjaxViewModel);
            }

            else
            {
                var userRoleAjaxErrorModel = JsonSerializer.Serialize(new UserRoleAssignAjaxViewModel
                {
                    RoleAssignPartial = await this.RenderViewToStringAsync("_RoleAssignPartial", userRoleAssignDto),
                    UserRoleAssignDto = userRoleAssignDto
                });

                return Json(userRoleAjaxErrorModel);

            }
        }
    }
}
