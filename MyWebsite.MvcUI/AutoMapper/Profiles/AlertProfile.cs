using AutoMapper;
using MyWebsite.Entities.Concrete;
using MyWebsite.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebsite.MvcUI.AutoMapper.Profiles
{
    public class AlertProfile :Profile
    {
        public AlertProfile()
        {
            CreateMap<Alert, AlertUpdateDto>().ReverseMap();
            CreateMap<AlertAddDto, Alert>();
        }
    }
}
