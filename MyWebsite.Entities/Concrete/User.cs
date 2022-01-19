using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;


namespace MyWebsite.Entities.Concrete
{
    public class User:IdentityUser<int>
    {
        public ICollection<News> News { get; set; }
        public ICollection<Announcement> Announcements { get; set; }
        public string Picture { get; set; }
        public string About { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
