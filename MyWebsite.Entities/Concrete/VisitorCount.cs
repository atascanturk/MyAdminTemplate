using MyWebsite.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebsite.Entities.Concrete
{
    public class VisitorCount : IEntity
    {
        public int Id { get; set; }
        public long Count { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
    }
}
