using MyWebsite.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebsite.MvcUI.Models
{
    public class GetProjectViewModel
    {
        public Project Project { get; set; }
        public List<Project> ProjectList { get; set; }
    }
}
