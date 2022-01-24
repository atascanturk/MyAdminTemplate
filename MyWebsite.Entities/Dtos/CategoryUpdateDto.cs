using MyWebsite.Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebsite.Entities.Dtos
{
    public class CategoryUpdateDto
    {
        public int Id { get; set; }

        [DisplayName("Kategori Adı")]
        [Required(ErrorMessage = "{0} boş geçilmemelidir.")]
        [MaxLength(50, ErrorMessage = "{0} {1} karakterden büyük olmamalıdır.")]
        [MinLength(2, ErrorMessage = "{0} {1} karakterden küçük olmamalıdır.")]
        public string Name { get; set; }

        [DisplayName("Kategori Tipi")]
        [Required(ErrorMessage = "{0} boş geçilmemelidir.")]
        public CategoryType CategoryType { get; set; }
    }
}
