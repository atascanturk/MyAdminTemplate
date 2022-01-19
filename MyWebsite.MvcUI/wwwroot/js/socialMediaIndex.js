$(document).ready(function () {
    $(document).on('click',
        '.btn-add',
        function (event) {
            event.preventDefault();
            let socialMedia = {
                Id:$('#socialMediaHdnId').val(),
                InstagramLink: $('#txtInstagram').val(),
                FacebookLink: $('#txtFacebook').val(),
                TwitterLink: $('#txtTwitter').val(),
                YoutubeLink: $('#txtYoutube').val(),
                LinkedInLink: $('#txtLinkedIn').val()
            };
            $.ajax({
                type: 'POST',
                dataType: 'json',
                data: socialMedia,
                url: '/WNqGRjUh3JPe/SocialMedia/AddSocialMedia/',
                success: function (data) {
                    if (!data.success) {                      
                        toastr.error(`${data.message}`, "Hata!")
                    }
                    else {                       
                        Swal.fire({
                            icon: 'success',
                            title: 'Kaydedildi',
                            text: 'Sosyal Media Url düzenlemeleri başarıyla kaydedildi.',
                        });
                    }
                  
                    
                },
                error: function (err) {
                    console.log(err.responseText);
                    console.log(err);
                    toastr.error(`${err.responseText}`, "Hata!")
                }
            });
        });
});