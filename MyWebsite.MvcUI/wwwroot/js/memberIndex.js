$(document).ready(function () {

    // For todays date;
    Date.prototype.today = function () {
        return ((this.getDate() < 10) ? "0" : "") + this.getDate() + "." + (((this.getMonth() + 1) < 10) ? "0" : "") + (this.getMonth() + 1) + "." + this.getFullYear();
    }

    // For the time now
    Date.prototype.timeNow = function () {
        return ((this.getHours() < 10) ? "0" : "") + this.getHours() + "." + ((this.getMinutes() < 10) ? "0" : "") + this.getMinutes();
    }


    const dataTable = $('#memberDataTable').DataTable({
        dom: "<'row'<'col-sm-3'l><'col-sm-6 text-center'B><'col-sm-3'f>>" +
            "<'row'<'col-sm-12'tr>>" +
            "<'row'<'col-sm-5'i><'col-sm-7'p>>",
        buttons: [
            {
                extend: 'colvis',
                className: "btn btn-light",
                text: 'Sütun Görünürlük'
            },

            {
                extend: 'excelHtml5',
                className: "btn btn-success",
                filename: function () {
                    var d = new Date();
                    var n = d.today() + "-" + d.timeNow();
                    return 'Üyeler-' + n;
                },
            },
            {
                extend: 'pdfHtml5',
                className: "btn btn-danger",
                filename: function () {
                    var d = new Date();
                    var n = d.today() + "-" + d.timeNow();
                    return 'Üyeler-' + n;
                },
            },
            {
                extend: 'copyHtml5',
                className: "btn btn-primary",
                text: 'Kopyala'
               
            }    
                      
          
           
           
        ],
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

   
});