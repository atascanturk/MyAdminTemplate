$(document).ready(function () {
   

    const placeHolderDiv = $('#modalPlaceHolder');
    $.ajax({
        type: 'GET',
        url: '/Alert/GetAlert/',
        contentType: "application/json",      
        success: function (data) {
            
                placeHolderDiv.html(data);
                placeHolderDiv.find(".modal").modal('show');
                    
           
        },
        error: function (err) {
            console.log(err);
          
        }
    });

        
});