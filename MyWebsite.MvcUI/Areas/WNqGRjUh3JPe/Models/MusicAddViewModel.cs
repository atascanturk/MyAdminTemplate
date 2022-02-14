using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebsite.MvcUI.Areas.Admin.Models
{
    public class MusicAddViewModel
    {
        [DisplayName("Müzik Dosyası")]
        [Required(ErrorMessage = "Lütfen, bir {0} seçiniz.")]
        [DataType(DataType.Upload)]
        public IFormFile MusicFile { get; set; }

        [DisplayName("Müzik Adı")]
        [Required(ErrorMessage = "Lütfen, bir {0} giriniz.")]
        public string Name { get; set; }
    }
}
