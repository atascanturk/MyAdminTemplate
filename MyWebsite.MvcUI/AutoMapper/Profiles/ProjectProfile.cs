using AutoMapper;
using MyWebsite.Entities.Concrete;
using MyWebsite.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebsite.MvcUI.AutoMapper.Profiles
{
    public class ProjectProfile :Profile
    {
        public ProjectProfile()
        {
            CreateMap<ProjectAddDto, Project>();
            CreateMap<ProjectUpdateDto, Project>().ReverseMap();
        }
    }
}
