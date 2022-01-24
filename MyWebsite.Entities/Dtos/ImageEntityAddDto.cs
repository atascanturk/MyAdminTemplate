using Microsoft.AspNetCore.Http;
using MyWebsite.Entities.Concrete;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MyWebsite.Entities.Dtos
{
    public class ImageEntityAddDto
    {
        [DisplayName("Resim")]
        [Required(ErrorMessage = "Lütfen, bir {0} seçiniz.")]
        [DataType(DataType.Upload)]
        public IFormFile PictureFile { get; set; }
        public string Picture { get; set; }

        [DisplayName("Kategori")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir. ")]
        public int CategoryId { get; set; }

        public IList<Category> Categories { get; set; }

    }
}
