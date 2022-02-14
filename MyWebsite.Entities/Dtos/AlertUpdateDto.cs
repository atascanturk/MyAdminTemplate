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
    public class AlertUpdateDto
    {
        [Required]
        public int Id { get; set; }

        [DisplayName("İçerik")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir. ")]
        [MinLength(5, ErrorMessage = "{0} alanı {1} karakterden küçük olmamalıdır.")]
        public string Content { get; set; }
               
        public IFormFile File { get; set; }

        [DisplayName("Dosya")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir. ")]
        public string FilePath { get; set; }
    }
}
