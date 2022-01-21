using AutoMapper;
using MyWebsite.Entities.Concrete;
using MyWebsite.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebsite.MvcUI.AutoMapper.Profiles
{
    public class AdministrativeStaffProfile : Profile
    {
        public AdministrativeStaffProfile()
        {
            CreateMap<AdministrativeStaffAddDto, AdministrativeStaff>();
            CreateMap<AdministrativeStaffUpdateDto, AdministrativeStaff>().ReverseMap();
        }
    }
}
