$(document).ready(function () {

    //Trumbowgy

    $('#text-editor').trumbowyg({
        btns: [
            ['viewHTML'],
            ['undo', 'redo'], // Only supported in Blink browsers
            ['formatting'],
            ['strong', 'em', 'del'],
            ['superscript', 'subscript'],
            ['link'],
            ['insertImage'],
            ['justifyLeft', 'justifyCenter', 'justifyRight', 'justifyFull'],
            ['unorderedList', 'orderedList'],
            ['horizontalRule'],
            ['removeformat'],
            ['fullscreen'],
            ['foreColor', 'backColor'],
            ['emoji'],
            ['fontfamily'],
            ['fontsize']
        ],
        lang: "tr",
    });

     //Trumbowgy

     //Select2

    $('#categoryList').select2({
        theme: 'bootstrap4',
        placeholder: "Lütfen bir kategori seçiniz...",
        allowClear: true
    });
      //Select2


      //JQuery UI - DatePicker
    //$(function () {
    //    $("#datePicker").datepicker({
    //        closeText: "kapat",
    //        prevText: "&#x3C;geri",
    //        nextText: "ileri&#x3e",
    //        currentText: "bugün",
    //        monthNames: ["Ocak", "Şubat", "Mart", "Nisan", "Mayıs", "Haziran",
    //            "Temmuz", "Ağustos", "Eylül", "Ekim", "Kasım", "Aralık"],
    //        monthNamesShort: ["Oca", "Şub", "Mar", "Nis", "May", "Haz",
    //            "Tem", "Ağu", "Eyl", "Eki", "Kas", "Ara"],
    //        dayNames: ["Pazar", "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma", "Cumartesi"],
    //        dayNamesShort: ["Pz", "Pt", "Sa", "Ça", "Pe", "Cu", "Ct"],
    //        dayNamesMin: ["Pz", "Pt", "Sa", "Ça", "Pe", "Cu", "Ct"],
    //        weekHeader: "Hf",
    //        dateFormat: "dd.mm.yy",
    //        firstDay: 1,
    //        isRTL: false,
    //        showMonthAfterYear: false,
    //        yearSuffix: "",
    //        duration: 600,
    //        showAnim: "drop",
    //        showOptions: {direction:"down"},            
    //        maxDate:+0
       
    //    });
    //});
     //JQuery UI - DatePicker

    $('#datePicker').datetimepicker({
        ownerDocument: document,
        contentWindow: window,

        value: '',
        rtl: false,

        format: 'd/m/Y H:i',
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
        minDateTime: false,
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
        allowDates: [],
        allowDateRe: null,
        disabledDates: [],
        disabledWeekDays: [],
        yearOffset: 0,
        beforeShowDay: null,

        enterLikeTab: true,
        showApplyButton: false
    });
});