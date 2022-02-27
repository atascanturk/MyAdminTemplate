using MyWebsite.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebsite.MvcUI.Models
{
    public class GetNewsViewModel
    {
        public News News { get; set; }
        public List<News> NewsList { get; set; }
    }
}
