using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebsite.Entities.Dtos
{
    public class VideoAddDto
    {
        [DisplayName("Youtube Video Url")]
        [Required(ErrorMessage = "Lütfen, bir {0} giriniz.")]
        [DataType(DataType.Url)]
        public string Root { get; set; }
    }
}
