$(document).ready(function () {



    $(document).on('click',
        '#bulletinUpperSubscribe',
        function (event) {
            event.preventDefault();
            const email = $('#bulletinUpperEmail').val();
            const bulletin = { Email: email, IsDeleted: false}
            $.ajax({
                type: 'POST',
                dataType: 'json',
                data: { bulletinAddViewModel : bulletin },
                url: '/Bulletin/Subscribe/',
                success: function (data) {
                    const result = jQuery.parseJSON(data);
                    if (result.IsError == false) {
                        $('#txtbulletinUpperResult').text("Bülten başvurunuz başarıyla alınmıştır.");
                        $('#txtbulletinUpperResult').removeClass("text-danger").addClass("text-success");
                        $('#txtbulletinUpperResult').css("display", "unset");
                    }

                    else {
                        $('#txtbulletinUpperResult').text(result.Message);
                        $('#txtbulletinUpperResult').removeClass("text-success").addClass("text-danger");
                        $('#txtbulletinUpperResult').css("display", "unset");
                    }

                },
                error: function (err) {
                    console.log(err);                    
                }
            });
        })

    $(document).on('click',
        '#bulletinBottomSubscribe',
        function (event) {
            event.preventDefault();
            const email = $('#bulletinBottomEmail').val();
            const bulletin = { Email: email , IsDeleted:false }
            $.ajax({
                type: 'POST',
                dataType: 'json',
                data: { bulletinAddViewModel : bulletin },
                url: '/Bulletin/Subscribe/',
                success: function (data) {
                    const result = jQuery.parseJSON(data);
                    if (result.IsError == false) {
                        $('#txtbulletinBottomResult').text("Bülten başvurunuz başarıyla alınmıştır.");
                        $('#txtbulletinBottomResult').removeClass("text-danger").addClass("text-success");                                              
                        $('#txtbulletinBottomResult').css("display", "unset");
                    }

                    else {
                        $('#txtbulletinBottomResult').text(result.Message);
                        $('#txtbulletinBottomResult').removeClass("text-success").addClass("text-danger");
                        $('#txtbulletinBottomResult').css("display", "unset");
                       
                    }
                   

                },
                error: function (err) {
                    console.log(err);                    
                }
            });
        })
});



