using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MyWebsite.Business.Abstract;
using MyWebsite.Core.Utilities.Results.ComplexTypes;
using MyWebsite.Entities.Concrete;
using MyWebsite.MvcUI.Models;
using NToastNotify;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebsite.MvcUI.Controllers
{
    public class MemberController : Controller
    {
        IMemberService _memberService;       
        IMapper _mapper;

        public MemberController(IMemberService memberService, IMapper mapper)
        {
            _memberService = memberService;
            _mapper = mapper;
        }

        [HttpGet("BizeKatilin")]
        public IActionResult Index()
        {     
            return View();
        }

        public IActionResult InformationForm()
        {
            return PartialView("_InformationFormPartial");
        }

        [HttpPost]
        public IActionResult AddMember(MemberAddViewModel memberAddViewModel)
        {
            var member = _mapper.Map<Member>(memberAddViewModel);
            
            if (ModelState.IsValid)
            {
                var result = _memberService.Add(member);
                if (result.ResultStatus == ResultStatus.Success)
                {                    
                    ModelState.AddModelError("RealPersonValidatorSuccess", $"Merhaba Sayın {memberAddViewModel.FirstName} {memberAddViewModel.LastName}, üyelik talebinizi başarıyla aldık. Partimize ve bizlere olan ilginize teşekkür eder, en kısa zamanda sizlerle iletişime geçeceğimizi bildirmek isteriz."); 
                    return View("Index");
                }

                else
                {
                    ModelState.AddModelError("RealPersonValidator", result.Message);
                }
                
            }
                           
                return View("Index",memberAddViewModel);
            
        }
    }
}
