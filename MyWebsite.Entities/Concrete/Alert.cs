﻿using MyWebsite.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebsite.Entities.Concrete
{
    public class Alert :IEntity
    {
        public int Id { get; set; }
        public string FilePath { get; set; }
        public string Content { get; set; }
        public bool IsDeleted { get; set; }
    }
}
