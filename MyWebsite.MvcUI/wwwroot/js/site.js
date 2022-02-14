// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {

    if ($("#navItemValue").val() == "anasayfa")
        $("li.nav-item-anasayfa").addClass('active');

    if ($("#navItemValue").val() == "kadromuz")
        $("li.nav-item-kadromuz").addClass('active');

    if ($("#navItemValue").val() == "haberler")
        $("li.nav-item-haberler").addClass('active');

    if ($("#navItemValue").val() == "duyurular")
        $("li.nav-item-duyurular").addClass('active');

    if ($("#navItemValue").val() == "kadinKollari")
        $("li.nav-item-kadinKollari").addClass('active');

    if ($("#navItemValue").val() == "iletisim")
        $("li.nav-item-iletisim").addClass('active');

    if ($("#navItemValue").val() == "partimiz")
        $("li.nav-item-partimiz").addClass('active');
       
    $('li.click').click(function () {      
        
        $("li.active").removeClass("active");
        $(this).addClass("active");
    })
      

});