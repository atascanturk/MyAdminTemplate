
$(document).ready(function () {
    const dataTable = $('#newsTable').DataTable({
        language: {
            "sDecimal": ",",
            "sEmptyTable": "Tabloda herhangi bir veri mevcut değil",
            "sInfo": "_TOTAL_ kayıttan _START_ - _END_ arasındaki kayıtlar gösteriliyor",
            "sInfoEmpty": "Kayıt yok",
            "sInfoFiltered": "(_MAX_ kayıt içerisinden bulunan)",
            "sInfoPostFix": "",
            "sInfoThousands": ".",
            "sLengthMenu": "Sayfada _MENU_ kayıt göster",
            "sLoadingRecords": "Yükleniyor...",
            "sProcessing": "İşleniyor...",
            "sSearch": "Ara:",
            "sZeroRecords": "Eşleşen kayıt bulunamadı",
            "oPaginate": {
                "sFirst": "İlk",
                "sLast": "Son",
                "sNext": "Sonraki",
                "sPrevious": "Önceki"
            },
            "oAria": {
                "sSortAscending": ": artan sütun sıralamasını aktifleştir",
                "sSortDescending": ": azalan sütun sıralamasını aktifleştir"
            },
            "select": {
                "rows": {
                    "_": "%d kayıt seçildi",
                    "0": "",
                    "1": "1 kayıt seçildi"
                }
            }
       

    });




    $(document).on('click',
        '.btn-delete',
        function (event) {
            event.preventDefault();
            const id = $(this).attr('data-id');
            const tableRow = $(`[name="${id}"]`);
            const newsTitle = tableRow.find('td:eq(1)').text();
            Swal.fire({
                title: 'Silmek istediğinize emin misiniz?',
                text: `${newsTitle} başlıklı haber silinicektir!`,
                icon: 'warning',
                showCancelButton: true,
                confirmButtonColor: '#3085d6',
                cancelButtonColor: '#d33',
                confirmButtonText: 'Evet, silmek istiyorum.',
                cancelButtonText: 'Hayır, silmek istemiyorum.'
            }).then((result) => {
                if (result.isConfirmed) {
                    $.ajax({
                        type: 'POST',
                        dataType: 'json',
                        data: { id: id },
                        url: '/WNqGRjUh3JPe/News/DeleteNews/',
                        success: function (data) {
                            const news = jQuery.parseJSON(data);
                            Swal.fire(
                                'Silindi!',
                                `${news.Title} başlıklı haber başarıyla silinmiştir.`,
                                'success'
                            );
                            dataTable.row(tableRow).remove().draw();

                        },
                        error: function (err) {
                            console.log(err);
                            toastr.error(`${err.responseText}`, "Hata!")
                        }
                    });
                }
            });
        });


    $(document).on('click',
        '.btn-changestatus',
        function (event) {
            event.preventDefault();
            const id = $(this).attr('data-id');
            const queue = $(this).attr('data-queue');
            const tableRow = $(`[name="${id}"]`);            
            $.ajax({
                type: 'POST',
                dataType: 'json',
                data: { id: id },
                url: '/WNqGRjUh3JPe/News/ChangeStatus/',
                success: function (data) {
                    const news = jQuery.parseJSON(data);
                    dataTable.row(tableRow).data([
                        queue,
                        news.Title,
                        news.Category.Name,
                        `<img src="/img/${news.Thumbnail}" alt="Resim Bulunamadı" class="my-image"/>`,
                        `${news.IsActive ? "Aktif" : "Pasif"}  <a class='${news.IsActive ? "btn btn-danger btn-sm btn-changestatus" : "btn btn-success btn-sm btn-changestatus"}' style='color:white; float:right;' data-id='${news.Id}' data-queue="${queue}" asp-area="WNqGRjUh3JPe" asp-controller="News" asp-action="ChangeStatus" asp-route-announcementId="${news.Id}"><span class="fas fa-remove"></span>  ${(news.IsActive == true ? "Pasif Yap" : "Aktif Yap")}</a></td> ` ,
                        `                         
                <a class='btn btn-primary btn-sm btn-update' style='color:white;' data-id="${news.Id}" data-queue="${queue}" href="/WNqGRjUh3JPe/News/UpdateNews/${news.Id}"><span class="fas fa-edit"></span></a>
                            <button class="btn btn-danger btn-sm btn-delete" data-id="${news.Id}" data-queue="${queue}" ><span class="fas fa-minus-circle"></span></button>`
                    ]);
                    tableRow.attr("name", `${id}`);
                    dataTable.row(tableRow).invalidate();
                    

                },
                error: function (err) {
                    console.log(err);
                    toastr.error(`${err.responseText}`, "Hata!")
                }
            });
        });
            
        
});