using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyWebsite.Business.Abstract;
using MyWebsite.MvcUI.Helpers;
using MyWebsite.MvcUI.Models;

namespace MyWebsite.MvcUI.Controllers
{
    public class ProjectController : Controller
    {
        IProjectService _projectService;

        public ProjectController(IProjectService projectService)
        {
            _projectService = projectService;
        }

        [HttpGet("Projeler")]
        public IActionResult Index()
        {
            var projects = _projectService.GetAllByNonDeleted();
            return View(projects);
        }

        [HttpGet("Projeler/{id}/{title}", Name = "Projeler")]
        public IActionResult GetProjectById(int id, string title)
        {
            var project = _projectService.GetByIdNonDeleted(id, null);
            var projectList = _projectService.GetAllByNonDeleted().OrderByDescending(x => x.Id).Take(3).ToList();

            if (project == null)
            {

                return NotFound();
            }
            var str = ChangeCharsToEnglish(project.Title.ToLower());
            // Get the actual friendly version of the title.
            string friendlyTitle = FriendlyUrlHelper.GetFriendlyTitle(str);

            // Compare the title with the friendly title.
            if (!string.Equals(friendlyTitle, title, StringComparison.Ordinal))
            {
                // If the title is null, empty or does not match the friendly title, return a 301 Permanent
                // Redirect to the correct friendly URL.
                return this.RedirectToRoutePermanent("Projeler", new { title = friendlyTitle.ToLower() });
            }
            return View(new GetProjectViewModel { Project = project, ProjectList = projectList });

        }

        private string ChangeCharsToEnglish(string str)
        {
            return str.Replace("ö", "o").Replace("ü", "u").Replace("ç", "c").Replace("ğ", "g").Replace("ş", "s").Replace("ı", "i");
        }
    }
}
