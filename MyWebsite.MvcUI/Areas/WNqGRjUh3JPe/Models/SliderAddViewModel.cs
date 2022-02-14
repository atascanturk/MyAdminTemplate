using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebsite.MvcUI.Areas.Admin.Models
{
    public class SliderAddViewModel
    {
        [DisplayName("Resim")]
        [Required(ErrorMessage = "Lütfen, bir {0} seçiniz.")]
        [DataType(DataType.Upload)]
        public IFormFile SliderPic { get; set; }

        [DisplayName("Başlık")]
        [Required(ErrorMessage = "Lütfen, bir {0} giriniz.")]
        public string Title { get; set; }
    }
}
