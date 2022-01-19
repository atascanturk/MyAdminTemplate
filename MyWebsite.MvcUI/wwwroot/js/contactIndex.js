$(document).ready(function () {
  const dataTable =  $('#contactDataTable').DataTable({                
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
        },
        "order": [[0, "asc"]]

  });

    $(function () {

        const url = '/WNqGRjUh3JPe/Contact/GetDetails/';
        const placeHolderDiv = $('#modalPlaceHolder');
        $(document).on('click',
            '.btn-detail',
            function (event) {
                event.preventDefault();
                const id = $(this).attr('data-id');
                $.get(url, { contactId: id }).done(function (data) {
                    placeHolderDiv.html(data);
                    placeHolderDiv.find('.modal').modal('show');
                }).fail(function (err) {
                    toastr.error(`${err.responseText}`, 'Hata!');
                });
            });

    });

    function convertToShortDate(dateString) {
        const shortDate = ` ${new Date(dateString).toLocaleDateString('tr-TR')} ${new Date(dateString).getHours()}:${new Date(dateString).getMinutes()}:${new Date(dateString).getSeconds()}`;
        return shortDate;
    }

    $(document).on('click',
        '.btn-close',
        function (event) {
            event.preventDefault();
            const id = $('#hiddenId').val();
            const tableRow = $(`[name="${id}"]`);
            $.ajax({
                type: 'POST',
                dataType: 'json',
                data: { contactId: id },
                url: '/WNqGRjUh3JPe/Contact/ChangeStatus/',
                success: function (data) {
                    const contact = jQuery.parseJSON(data);
                    dataTable.row(tableRow).data([
                        contact.Id,
                        contact.Subject,
                        contact.Mail,
                        convertToShortDate(contact.CreatedDate),
                        `<span style='${contact.IsRead == true ? 'color:green;' : 'color:red;'}' class='${contact.IsRead == true ? 'fas fa-check-double' : 'fas fa-times'}'></span>${contact.IsRead == true ? ' Görüldü' : ' Okunmadı.'}`,
                        `<button class="btn btn-info btn-sm btn-detail" data-id="${contact.Id}"><span class="far fa-envelope-open"></span></button>
                             <button class="btn btn-danger btn-sm btn-delete" data-id="${contact.Id}"><span class="fas fa-minus-circle"></span></button>`
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