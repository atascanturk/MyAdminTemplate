using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyWebsite.Business.Abstract;
using MyWebsite.Entities.Concrete;
using MyWebsite.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace MyWebsite.MvcUI.Areas.WNqGRjUh3JPe.Controllers
{
    [Area("WNqGRjUh3JPe")]
    [Authorize(Roles = "Admin,SuperAdmin,Developer")]
    public class CategoryController : Controller
    {
        ICategoryService _categoryService;
        IMapper _mapper;

        public CategoryController(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var categories = _categoryService.GetAllByNonDeleted();
            return View(categories);
        }

        [HttpGet]
        public IActionResult AddCategory()
        {           
            return View();
        }

        [HttpPost]
        public IActionResult AddCategory(CategoryAddDto categoryAddDto)
        {
            if (ModelState.IsValid)
            {
               var category=  _mapper.Map<Category>(categoryAddDto);
                _categoryService.Add(category);
                return RedirectToAction("Index", "Category",new { Area = "WNqGRjUh3JPe" });
            }
            else
            {
                return View(categoryAddDto);
            }
        }

        [HttpGet]
        public IActionResult Update(int id)
        {           
            var category = _categoryService.Get(x => x.Id == id);
           var categoryUpdateDto = _mapper.Map<CategoryUpdateDto>(category);
            return View(categoryUpdateDto);
        }

        [HttpPost]
        public IActionResult Update(CategoryUpdateDto categoryUpdateDto )
        {
            if (ModelState.IsValid)
            {
               var category = _mapper.Map<Category>(categoryUpdateDto);
                _categoryService.Update(category);
                return RedirectToAction("Index", "Category", new { Area = "WNqGRjUh3JPe" });
            }

            else
            {
                return View(categoryUpdateDto);
            }
           
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var category = _categoryService.Get(x => x.Id == id);
            category.IsDeleted = true;            
            var jsoncategory = JsonSerializer.Serialize(category);
            _categoryService.Update(category);


            return Json(jsoncategory);

        }
    }
}
