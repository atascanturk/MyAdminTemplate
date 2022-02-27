using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MyWebsite.Business.Abstract;
using MyWebsite.Entities.Concrete;
using MyWebsite.MvcUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace MyWebsite.MvcUI.Controllers
{
    public class BulletinController : Controller
    {
        IBulletinService _bulletinService;
        IMapper _mapper;

        public BulletinController(IBulletinService bulletinService, IMapper mapper)
        {
            _bulletinService = bulletinService;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult Subscribe(BulletinAddViewModel bulletinAddViewModel)
        {
            if (ModelState.IsValid)
            {
                var bulletin = _mapper.Map<Bulletin>(bulletinAddViewModel);
                if (!_bulletinService.GetAllByNonDeleted().Where(x => x.Email == bulletin.Email).Any())
                {
                    
                    _bulletinService.Add(bulletin);
                    var result = new { IsError = false };
                    var jsonResult = JsonSerializer.Serialize(result);
                    return Json(jsonResult);
                }

                else
                {
                    var result = new { IsError = true, Message = "Bu abone sistemimizde mevcut." };
                    var jsonResult = JsonSerializer.Serialize(result);
                    return Json(jsonResult);
                }
            }
            else
            {
                var result = new { IsError = true, Message = "Geçersiz e-posta adresi." };
                var jsonResult = JsonSerializer.Serialize(result);
                return Json(jsonResult);
            }
            
        }
    }
}
