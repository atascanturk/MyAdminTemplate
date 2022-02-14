using MyWebsite.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebsite.Entities.Concrete
{
    public class Seo : IEntity
    {
        public int Id { get; set; }
        public string SeoDescription { get; set; }
        public string SeoAuthor { get; set; }
        public string SeoTags { get; set; }
        public DateTime UpdatedDate { get; set; } = DateTime.Now;
    }
}
