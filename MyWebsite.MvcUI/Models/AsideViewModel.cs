using MyWebsite.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebsite.MvcUI.Models
{
    public class AsideViewModel
    {

        public SocialMedia SocialMedia { get; set; }
        public List<Announcement> Announcements{ get; set; }
        
    }
}
