using MyWebsite.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebsite.Entities.Concrete
{
    public class Image :IEntity
    {
        public int Id { get; set; }
        public string Path { get; set; }
        public bool IsDeleted { get; set; } = false;
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
