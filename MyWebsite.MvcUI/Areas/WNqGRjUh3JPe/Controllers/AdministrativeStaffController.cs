using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyWebsite.Business.Abstract;
using MyWebsite.Entities.ComplexTypes;
using MyWebsite.Entities.Concrete;
using MyWebsite.Entities.Dtos;
using MyWebsite.Entities.Enums;
using MyWebsite.Mvc.Helpers.Abstract;

namespace MyWebsite.MvcUI.Areas.WNqGRjUh3JPe.Controllers
{
    [Area("WNqGRjUh3JPe")]
    [Authorize(Roles = "Admin,SuperAdmin,Developer")]
    public class AdministrativeStaffController : Controller
    {
        IAdministrativeStaffService _administrativeStaffService;
        ICategoryService _categoryService;
        IMapper _mapper;
        IImageHelper _imageHelper;

        public AdministrativeStaffController(IAdministrativeStaffService administrativeStaffService, IMapper mapper, IImageHelper imageHelper, ICategoryService categoryService)
        {
            _administrativeStaffService = administrativeStaffService;
            _mapper = mapper;
            _imageHelper = imageHelper;
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            var staff = _administrativeStaffService.GetAllByNonDeleted();
            return View(staff);
        }

        [HttpGet]
        public IActionResult Add()
        {
            var categories = _categoryService.GetAllByNonDeleted().Where(x => x.CategoryType == Convert.ToInt32(CategoryType.Yönetim)).ToList();
            return View(new AdministrativeStaffAddDto
            {
                Categories = categories
            });
        }


        [HttpPost]
        public async Task<IActionResult> Add(AdministrativeStaffAddDto administrativeStaffAddDto)
        {
            if (ModelState.IsValid)
            {
                var newStaff = _mapper.Map<AdministrativeStaff>(administrativeStaffAddDto);
                var imageResult = await _imageHelper.Upload("Staff",
                         administrativeStaffAddDto.PictureFile, PictureType.Staff, "staffImages");
                newStaff.ImagePath = imageResult.Data.FullName;
                _administrativeStaffService.Add(newStaff);
                return RedirectToAction("Index", "AdministrativeStaff");

            }
            var categories = _categoryService.GetAllByNonDeleted().Where(x => x.CategoryType == Convert.ToInt32(CategoryType.Yönetim)).ToList();
            administrativeStaffAddDto.Categories = categories;
            return View(administrativeStaffAddDto);
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var categories = _categoryService.GetAllByNonDeleted().Where(x => x.CategoryType == Convert.ToInt32(CategoryType.Yönetim)).ToList();
            var staff = _administrativeStaffService.Get(x => x.Id == id);
            var administrativeStaffUpdateDto = _mapper.Map<AdministrativeStaffUpdateDto>(staff);
            administrativeStaffUpdateDto.Categories = categories;
            return View(administrativeStaffUpdateDto);
        }

        [HttpPost]
        public IActionResult Update(AdministrativeStaffUpdateDto administrativeStaffUpdateDto)
        {
            if (ModelState.IsValid)
            {

                bool isNewPictureUploaded = false;
                var oldstaff = _administrativeStaffService.Get(x => x.Id == administrativeStaffUpdateDto.Id);

                var oldNewsPicture = oldstaff.ImagePath;
                if (administrativeStaffUpdateDto.PictureFile != null)
                {
                    var uploadedImageResult = _imageHelper.Upload("Staff",
                      administrativeStaffUpdateDto.PictureFile, PictureType.Staff).Result;
                    administrativeStaffUpdateDto.ImagePath = uploadedImageResult.Data.FullName;

                    isNewPictureUploaded = true;
                }

                if (isNewPictureUploaded)
                {
                    _imageHelper.Delete(oldNewsPicture);
                }

                var staff = _mapper.Map<AdministrativeStaff>(administrativeStaffUpdateDto);
                _administrativeStaffService.Update(staff);

                return RedirectToAction("Index", "AdministrativeStaff");

            }

            else
            {
                var categories = _categoryService.GetAllByNonDeleted().Where(x => x.CategoryType == Convert.ToInt32(CategoryType.Yönetim)).ToList();
                administrativeStaffUpdateDto.Categories = categories;
                foreach (var modelState in ViewData.ModelState.Values)
                {
                    foreach (var error in modelState.Errors)
                    {
                        ModelState.AddModelError("", error.ErrorMessage);
                    }
                }
                return View(administrativeStaffUpdateDto);
            }
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var staff = _administrativeStaffService.Get(x => x.Id == id);
            staff.IsDeleted = true;
            var jsonStaff = JsonSerializer.Serialize(staff);
            _administrativeStaffService.Update(staff);


            return Json(jsonStaff);

        }
    }
}
