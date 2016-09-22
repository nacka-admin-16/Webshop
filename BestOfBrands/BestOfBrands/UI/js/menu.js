$(document).ready(function () {

    var pgurl = window.location.href.substr(window.location.href.lastIndexOf("/") + 1);

    $("#navbar ul li a").each(function () {
        if ($(this).attr("href") === '/Pages/' + pgurl || $(this).attr("href") === '') {
            $(this).closest('li').addClass("active");
        } else {
            $(this).closest('li').removeClass("active");
        }                        
    });
});