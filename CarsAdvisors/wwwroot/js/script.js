$(document).ready(function () {
    $(window).scroll(function () {
        var scroll = $(window).scrollTop();
        if (scroll > 40) {
            $(".navbar").css("background", "rgba(0, 0, 0, 0.526)");
            $(".navbar").css("position", "fixed");
            $(".navbar").css("top", "0");
        } 
    })
})