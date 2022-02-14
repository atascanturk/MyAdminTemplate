using Microsoft.AspNetCore.Mvc;
using MyWebsite.Business.Abstract;
using MyWebsite.Entities.Concrete;
using MyWebsite.MvcUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebsite.MvcUI.Controllers
{
    public class ContactController : Controller
    {
        IContactService _contactService;       

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;          
        }
        [HttpGet("Iletisim")]
        public IActionResult Index()
        {     
            return View();
        }

        public IActionResult AddContact(Contact contact)
        {
            _contactService.Add(contact);
            return RedirectToAction("Index");
        }
    }
}
