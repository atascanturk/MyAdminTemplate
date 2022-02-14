using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebsite.MvcUI.Models
{
    public class MemberAddViewModel
    {
        [DisplayName("TCKN")]
        [Required(ErrorMessage = "{0} boş geçilmemelidir.")]
        [MaxLength(11, ErrorMessage = "{0} {1} karakterden büyük olmamalıdır.")]
        [MinLength(11, ErrorMessage = "{0} {1} karakterden küçük olmamalıdır.")]
        public string IdentityNumber { get; set; }

        [DisplayName("Ad")]
        [Required(ErrorMessage = "{0} boş geçilmemelidir.")]       
        [MinLength(2, ErrorMessage = "{0} {1} karakterden küçük olmamalıdır.")]
        public string FirstName { get; set; }

        [DisplayName("Soyad")]
        [Required(ErrorMessage = "{0} boş geçilmemelidir.")]
        [MinLength(2, ErrorMessage = "{0} {1} karakterden küçük olmamalıdır.")]
        public string LastName { get; set; }

        [DisplayName("Doğum Tarihi")]
        [Required(ErrorMessage = "{0} boş geçilmemelidir.")]        
        public DateTime BirthOfDay { get; set; }

        [DisplayName("Telefon Numarası")]
        [MinLength(10, ErrorMessage = "{0} {1} karakterden küçük olmamalıdır.")]
        [Required(ErrorMessage = "{0} boş geçilmemelidir.")]        
        public string PhoneNumber { get; set; }
        [DisplayName("E-Posta")]
        [Required(ErrorMessage = "{0} boş geçilmemelidir.")]

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DisplayName("İl")]
        [Required(ErrorMessage = "{0} boş geçilmemelidir.")]        
        public string City { get; set; }

        [DisplayName("İlçe")]
        [Required(ErrorMessage = "{0} boş geçilmemelidir.")]
        [MinLength(2, ErrorMessage = "{0} {1} karakterden küçük olmamalıdır.")]
        public string District { get; set; }      
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public bool IsDeleted { get; set; } = false;

        [DisplayName("Meslek")]
        [Required(ErrorMessage = "{0} boş geçilmemelidir.")]
        [MinLength(2, ErrorMessage = "{0} {1} karakterden küçük olmamalıdır.")]
        public string Profession { get; set; }

        [DisplayName("KVKK Bilgilendirme Formu")]
        [Required(ErrorMessage = "{0} boş geçilmemelidir.")]       
        public bool IsAccepted { get; set; } 
    }
}
