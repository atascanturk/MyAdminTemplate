using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebsite.MvcUI.Areas.WNqGRjUh3JPe.Models
{
    public class SocialMediaUpdateViewModel
    {
        //regex = 

        public int Id { get; set; }

        [DisplayName("Instagram Url")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir. ")]
        [RegularExpression(@"^((ftp|http|https):\/\/)?www\.([A-z]+)\.([A-z]{2,})\/([A-z]{2,})\/?",
         ErrorMessage = "Lütfen örnek format ile uyumlu bir Instagram linki girin.")]
        public string InstagramLink { get; set; }

        [DisplayName("Facebook Url")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir. ")]
        [RegularExpression(@"^((ftp|http|https):\/\/)?www\.([A-z]+)\.([A-z]{2,})\/([A-z]{2,})\/?",
        ErrorMessage = "Lütfen örnek format ile uyumlu bir Facebook linki girin.")]
        public string FacebookLink { get; set; }

        [DisplayName("Twitter Url")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir. ")]
        [RegularExpression(@"^((ftp|http|https):\/\/)?www\.([A-z]+)\.([A-z]{2,})\/([A-z]{2,})\/?",
        ErrorMessage = "Lütfen örnek format ile uyumlu bir Twitter linki girin.")]
        public string TwitterLink { get; set; }

        [DisplayName("Youtube Url")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir. ")]
        [RegularExpression(@"^((ftp|http|https):\/\/)?www\.([A-z]+)\.([A-z]{2,})\/([A-z]{2,})\/?",
        ErrorMessage = "Lütfen örnek format ile uyumlu bir Youtube linki girin.")]
        public string YoutubeLink { get; set; }

        [DisplayName("LinkedIn Url")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir. ")]
        [RegularExpression(@"^((ftp|http|https):\/\/)?www\.([A-z]+)\.([A-z]{2,})\/([A-z]{2,})\/?",
        ErrorMessage = "Lütfen örnek format ile uyumlu bir LinkedIn linki girin.")]
        public string LinkedInLink { get; set; }
    }
}
