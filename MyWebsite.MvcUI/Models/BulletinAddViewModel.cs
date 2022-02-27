using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebsite.MvcUI.Models
{
    public class BulletinAddViewModel
    {
        [Required(ErrorMessage = "{0} alanı zorunludur")]
        [MaxLength(100, ErrorMessage = "{0} alanı en fazla {1} karakterden oluşmalıdır.")]
        [MinLength(10, ErrorMessage = "{0} alanı en az {1} karakterden oluşmalıdır.")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}
