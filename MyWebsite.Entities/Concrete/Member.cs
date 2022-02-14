using MyWebsite.Core.Entities;
using MyWebsite.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebsite.Entities.Concrete
{
    public class Member : Person , IEntity
    {
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public bool IsDeleted { get; set; }
        public string Profession { get; set; }
        public bool IsAccepted { get; set; }

    }
}
