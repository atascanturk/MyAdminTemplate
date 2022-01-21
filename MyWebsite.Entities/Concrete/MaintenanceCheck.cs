using MyWebsite.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebsite.Entities.Concrete
{
    public class MaintenanceCheck : IEntity
    {
        public int Id { get; set; }
        public bool IsUnderMaintenance { get; set; }
        [Required]
        public DateTime EndTime { get; set; }

    }
}
