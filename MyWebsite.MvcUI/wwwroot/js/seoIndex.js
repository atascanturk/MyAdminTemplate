$(document).ready(function () {
   


    $(document).on('click',
        '.btn-save',
        function (event) {
            event.preventDefault();
            const Seo = { Id: 1, SeoAuthor: $('#txtSeoAuthor').val(), SeoTags: $('#txtSeoTags').val(), SeoDescription: $('#txtSeoDescription').val() }
            $.ajax({
                type: 'Post',
                dataType: 'json',
                data: { seo: Seo },
                url: '/WNqGRjUh3JPe/Seo/Update/',
                success: function (data) {
                    Swal.fire(
                        'İşlem Başarılı',
                        'Seo ayarları kaydedildi.',
                        'success'
                    )
                },

                error: function (err) {
                    console.log(err);
                    toastr.error(`${err.responseText}`, "Hata!")
                }
            });
        });


});