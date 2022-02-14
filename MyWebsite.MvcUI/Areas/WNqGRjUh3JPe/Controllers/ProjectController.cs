using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyWebsite.Business.Abstract;
using MyWebsite.Entities.ComplexTypes;
using MyWebsite.Entities.Concrete;
using MyWebsite.Entities.Dtos;
using MyWebsite.Mvc.Helpers.Abstract;
using MyWebsite.MvcUI.Helpers.Concrete;
using Newtonsoft.Json;

namespace MyWebsite.MvcUI.Areas.WNqGRjUh3JPe.Controllers
{
    [Area("WNqGRjUh3JPe")]
    [Authorize(Roles = "Admin,SuperAdmin,Developer")]
    public class ProjectController : Controller
    {
        IProjectService _projectService;
        IMapper _mapper;
        IImageHelper _imageHelper;

        public ProjectController(IProjectService projectService, IMapper mapper, IImageHelper imageHelper)
        {
            _projectService = projectService;
            _mapper = mapper;
            _imageHelper = imageHelper;
        }

        public IActionResult Index()
        {
            var projects = _projectService.GetAllByNonDeleted();
            return View(projects);
        }

        [HttpGet]
        public IActionResult AddProject()
        {
            return View();

        }

        [HttpPost]
        public IActionResult AddProject(ProjectAddDto projectAddDto)
        {
            if (ModelState.IsValid)
            {
                var project = _mapper.Map<Project>(projectAddDto);

                var imageResult = _imageHelper.Upload(projectAddDto.Title,
                      projectAddDto.ThumbnailFile, PictureType.Project, "projectImages").Result;
                project.Thumbnail = imageResult.Data.FullName;
                _projectService.Add(project);
                return RedirectToAction("Index");
            }
            else
            {
                return View(projectAddDto);
            }

        }

        [HttpPost]
        public IActionResult DeleteProject(int id)
        {
            var project = _projectService.Get(x => x.Id == id);
            _imageHelper.Delete(project.Thumbnail);
            project.IsDeleted = true;
            var jsonProject = JsonConvert.SerializeObject(project);
            _projectService.Update(project);


            return Json(jsonProject);

        }

        [HttpGet]
        public IActionResult UpdateProject(int id)
        {
             var project = _projectService.Get(x => x.Id == id);
            var projectAddDto = _mapper.Map<ProjectUpdateDto>(project);           
            return View(projectAddDto);
        }

        public IActionResult UpdateProject(ProjectUpdateDto projectUpdateDto)
        {
            if (ModelState.IsValid)
            {
                bool isNewPictureUploaded = false;
                var oldnews = _projectService.Get(x => x.Id == projectUpdateDto.Id);

                var oldProjectPicture = oldnews.Thumbnail;
                if (projectUpdateDto.ThumbnailFile != null)
                {
                    var uploadedImageResult = _imageHelper.Upload(projectUpdateDto.Title,
                      projectUpdateDto.ThumbnailFile, PictureType.Post).Result;
                    projectUpdateDto.Thumbnail = uploadedImageResult.Data.FullName;

                    isNewPictureUploaded = true;
                }

                if (isNewPictureUploaded)
                {
                    _imageHelper.Delete(oldProjectPicture);
                }

                var project = _mapper.Map<Project>(projectUpdateDto);
                _projectService.Update(project);

                return RedirectToAction("Index");

            }

            else
            {                             
                return View(projectUpdateDto);
            }

        }
    }
}
