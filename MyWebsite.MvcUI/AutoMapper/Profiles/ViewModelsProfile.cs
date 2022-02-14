using AutoMapper;
using MyWebsite.Entities.Concrete;
using MyWebsite.MvcUI.Areas.Admin.Models;
using MyWebsite.MvcUI.Areas.WNqGRjUh3JPe.Models;
using MyWebsite.MvcUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebsite.MvcUI.AutoMapper.Profiles
{
    public class ViewModelsProfile :Profile
    {
        public ViewModelsProfile()
        {
            CreateMap<NewsAddViewModel, News>();
            CreateMap<SliderAddViewModel, Slider>();
            CreateMap<MusicAddViewModel, Music>();
            CreateMap<SocialMediaUpdateViewModel, SocialMedia>().ReverseMap();
            CreateMap<Announcement, AnnouncementAddViewModel>().ReverseMap();
            CreateMap<MemberAddViewModel, Member>();
            CreateMap<BulletinAddViewModel, Bulletin>();
        }
    }
}
