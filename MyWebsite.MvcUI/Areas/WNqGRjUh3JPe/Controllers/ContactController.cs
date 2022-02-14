using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyWebsite.Business.Abstract;
using MyWebsite.Entities.Dtos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebsite.MvcUI.Areas.WNqGRjUh3JPe.Controllers
{
    [Area("WNqGRjUh3JPe")]
    [Authorize(Roles = "Admin,SuperAdmin,Developer")]
    public class ContactController : Controller
    {
        IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        public IActionResult Index()
        {
            var contacts = _contactService.GetAllByNonDeleted();
            return View(contacts);
        }

        [HttpGet]
        public  PartialViewResult GetDetails(int contactId)
        {
            var contact = _contactService.Get(x => x.Id == contactId);
            contact.IsRead = true;
            _contactService.Update(contact);
            return PartialView("_GetDetailPartial", new ContactDto { Contact = contact });
        }

        [HttpPost]
        public IActionResult ChangeStatus(int contactId)
        {
            var contact = _contactService.Get(x => x.Id == contactId);
            contact.IsRead = true;
            _contactService.Update(contact);
          var jsonContact = JsonConvert.SerializeObject(contact);
            return Json(jsonContact);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var contact = _contactService.Get(x => x.Id == id);
            contact.IsDeleted = true;
            _contactService.Update(contact);


            return Json("");

        }
    }
}
