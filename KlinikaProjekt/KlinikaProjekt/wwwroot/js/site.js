// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


$(window).scroll(function () {
    if ($(this).scrollTop() > 100) {
        $('.back-to-topHome').fadeIn('slow');
    } else {
        $('.back-to-topHome').fadeOut('slow');
    }
});
$('.back-to-topHome').click(function () {
    $('html, body').animate({ scrollTop: 0 }, 1500, 'easeInOutExpo');
    return false;
});