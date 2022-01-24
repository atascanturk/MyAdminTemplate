using MyWebsite.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebsite.Entities.Concrete
{
    public class Category : IEntity
    {
        public int Id{ get; set; }
        public string Name { get; set; }      
        public ICollection<News> News { get; set; }
        public ICollection<Image> Images { get; set; }
        public ICollection<AdministrativeStaff> administrativeStaffs { get; set; }
        public int CategoryType { get; set; }
        public bool IsDeleted { get; set; } = false;

    }
}
