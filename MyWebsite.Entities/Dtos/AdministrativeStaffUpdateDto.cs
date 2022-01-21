using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebsite.Entities.Dtos
{
   public class AdministrativeStaffUpdateDto
    {
        [Required]
        public int Id { get; set; }

        [DisplayName("Ünvan")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir. ")]
        [MaxLength(80, ErrorMessage = "{0} alanı {1} karakterden büyük olmamalıdır.")]
        [MinLength(5, ErrorMessage = "{0} alanı {1} karakterden küçük olmamalıdır.")]
        public string Title { get; set; }

        [DisplayName("İsim")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir. ")]
        [MaxLength(40, ErrorMessage = "{0} alanı {1} karakterden büyük olmamalıdır.")]
        [MinLength(2, ErrorMessage = "{0} alanı {1} karakterden küçük olmamalıdır.")]
        public string FirstName { get; set; }

        [DisplayName("Soyisim")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir. ")]
        [MaxLength(30, ErrorMessage = "{0} alanı {1} karakterden büyük olmamalıdır.")]
        [MinLength(2, ErrorMessage = "{0} alanı {1} karakterden küçük olmamalıdır.")]
        public string LastName { get; set; }

        public IFormFile PictureFile { get; set; }

        [DisplayName("Resim")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir. ")]
        public string ImagePath { get; set; }
    }
}
