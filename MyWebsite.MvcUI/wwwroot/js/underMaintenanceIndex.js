$(document).ready(function () {
    $(document).on('click',
        '.btn-changestatus-get',
        function (event) {
            event.preventDefault();
            const form = $('#form-changestatus');
            const actionUrl = form.attr('action');
            const dataToSend = new FormData(form.get(0));
            $.ajax({
                type: 'POST',               
                dataType: 'json',
                data:dataToSend,
                url: actionUrl,
                processData: false,
                contentType: false,
                success: function (data) {
                    var result = jQuery.parseJSON(data);
                    form.css("display", "none");
                        $('#toMaintenance').text(" Bakımdan Çıkar").prepend("<i class='fas fa-cogs'></i>")
                        $('#toMaintenance').removeClass("btn btn-danger btn-changestatus-get").addClass("btn btn-success btn-changestatus-remove")
                    
                    Swal.fire(
                        'İşlem Başarılı',
                        'Site bakıma moduna alındı.',
                        'success'
                    )
                },
                error: function (err) {
                    console.log(err);
                    toastr.error(`${err.responseText}`, "Hata!")
                }
            });
        });

    $(document).on('click',
        '.btn-changestatus-remove',
        function (event) {
            event.preventDefault();
            const form = $('#form-changestatus');          
            $.ajax({
                type: 'Get',
                dataType: 'json',             
                url: "/WNqGRjUh3JPe/UnderMaintenance/ChangeStatus/",
                success: function (data) {
                    var result = jQuery.parseJSON(data);

                    form.css("display", "unset");
                    $('#toMaintenance').text(" Bakıma Al").prepend("<i class='fas fa-cogs'></i>")
                    $('#toMaintenance').removeClass("btn btn-success btn-changestatus-remove").addClass("btn btn-danger btn-changestatus-get")
                    
                    Swal.fire(
                        'İşlem Başarılı',
                        'Site bakım modundan çıkarıldı.',
                        'success'
                    )



                },
                error: function (err) {
                    console.log(err);
                    toastr.error(`${err.responseText}`, "Hata!")
                }
            });
        });


    $(document).on('click',
        '.btn-sendemail',
        function (event) {
            event.preventDefault();
            $.ajax({
                type: 'GET',
                dataType: 'json',
                url: '/WNqGRjUh3JPe/UnderMaintenance/SendTestEmailToAllUsers/',
                success: function (data) {                   
                    Swal.fire(
                        'İşlem Başarılı',
                        'Test maili tüm kullanıcılara başarıyla gönderildi.',
                        'success'
                    )
                }
                ,
                error: function (err) {
                    console.log(err);
                    toastr.error(`${err.responseText}`, "Hata!")
                }
            });
        });

    $(function () {
        $("#datePicker1").datepicker({
            closeText: "kapat",
            prevText: "&#x3C;geri",
            nextText: "ileri&#x3e",
            currentText: "bugün",
            monthNames: ["Ocak", "Şubat", "Mart", "Nisan", "Mayıs", "Haziran",
                "Temmuz", "Ağustos", "Eylül", "Ekim", "Kasım", "Aralık"],
            monthNamesShort: ["Oca", "Şub", "Mar", "Nis", "May", "Haz",
                "Tem", "Ağu", "Eyl", "Eki", "Kas", "Ara"],
            dayNames: ["Pazar", "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma", "Cumartesi"],
            dayNamesShort: ["Pz", "Pt", "Sa", "Ça", "Pe", "Cu", "Ct"],
            dayNamesMin: ["Pz", "Pt", "Sa", "Ça", "Pe", "Cu", "Ct"],
            weekHeader: "Hf",
            dateFormat: "dd.mm.yy",
            firstDay: 1,
            isRTL: false,
            showMonthAfterYear: false,
            yearSuffix: "",
            duration: 600,
            showAnim: "drop",
            showOptions: { direction: "down" },
            minDate: -1,
            maxDate: +3

        });
    });
    
    $('#datePicker').datetimepicker({
        ownerDocument: document,
        contentWindow: window,

        value: '',
        rtl: false,

        format: 'Y/m/d H:i',
        formatTime: 'H:i',
        formatDate: 'Y/m/d',

        startDate: false, // new Date(), '1986/12/08', '-1970/01/05','-1970/01/05',
        step: 60,
        monthChangeSpinner: true,

        closeOnDateSelect: false,
        closeOnTimeSelect: true,
        closeOnWithoutClick: true,
        closeOnInputClick: true,
        openOnFocus: true,

        timepicker: true,
        datepicker: true,
        weeks: false,

        defaultTime: false, // use formatTime format (ex. '10:00' for formatTime: 'H:i')
        defaultDate: false, // use formatDate format (ex new Date() or '1986/12/08' or '-1970/01/05' or '-1970/01/05')

        minDate: false,
        maxDate: false,
        minTime: false,
        maxTime: false,
        minDateTime: new Date(),
        maxDateTime: false,

        allowTimes: [],
        opened: false,
        initTime: true,
        inline: false,
        theme: '',
        touchMovedThreshold: 5,

        onSelectDate: function () { },
        onSelectTime: function () { },
        onChangeMonth: function () { },
        onGetWeekOfYear: function () { },
        onChangeYear: function () { },
        onChangeDateTime: function () { },
        onShow: function () { },
        onClose: function () { },
        onGenerate: function () { },

        withoutCopyright: true,
        inverseButton: false,
        hours12: false,
        next: 'xdsoft_next',
        prev: 'xdsoft_prev',
        dayOfWeekStart: 0,
        parentID: 'body',
        timeHeightInTimePicker: 25,        
        todayButton: true,
        prevButton: true,
        nextButton: true,
        defaultSelect: true,

        scrollMonth: true,
        scrollTime: true,
        scrollInput: true,

        lazyInit: false,
        mask: false,
        validateOnBlur: true,
        allowBlank: true,
        yearStart: 1950,
        yearEnd: 2050,
        monthStart: 0,
        monthEnd: 11,
        style: '',
        id: '',
        fixed: false,
        roundTime: 'round', // ceil, floor
        className: '',
        weekends: [],
        highlightedDates: [],
        highlightedPeriods: [],
        allowDates : [],
        allowDateRe : null,
        disabledDates : [],
        disabledWeekDays: [],
        yearOffset: 0,
        beforeShowDay: null,

        enterLikeTab: true,
        showApplyButton: false
});


});