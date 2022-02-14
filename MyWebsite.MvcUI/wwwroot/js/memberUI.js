$(document).ready(function () {
    $('.phone').mask('(599) 999 99 99');

    const url = '/Member/InformationForm/';
    const placeHolderDiv = $('#modalPlaceHolder');
    $('#informationForm').click(function () {
        $.get(url).done(function (data) {
            placeHolderDiv.html(data);
            placeHolderDiv.find(".modal").modal('show');
        });
    });

    placeHolderDiv.on('click', '#btnAccept', function (e) {

        e.preventDefault();
        $('#cbxAccept').prop('checked', true);

    })

    function titleCase(str) {
        var splitStr = str.toLowerCase().split(' ');
        for (var i = 0; i < splitStr.length; i++) {
            // You do not need to check if i is larger than splitStr length, as your for does that for you
            // Assign it back to the array
            splitStr[i] = splitStr[i].charAt(0).toUpperCase() + splitStr[i].substring(1);
        }
        // Directly return the joined string
        return splitStr.join(' ');
    }

    $('#name').change(() => {              
        const capitalizeName = titleCase($("#name").val())
        $("#name").val(capitalizeName);        

    })  

    $('#profession').change(() => {        
        const capitalizeProfession = titleCase($("#profession").val())
        $("#profession").val(capitalizeProfession);

    })

    $('#district').change(() => {        
        const capitalizeDistrict = titleCase($("#district").val())
        $("#district").val(capitalizeDistrict);

    })

    $('#phone').change(() => {      
        const phone = $('#phone').val().replaceAll(" ", "").replaceAll("(", "").replaceAll(")", "")
        const prefix = "+90";
        const fullPhone = prefix + phone;
        $('#phone').val(fullPhone)       

    })

    $('#phone').focus(() => {       
        $('#phone').val("")

    })

});