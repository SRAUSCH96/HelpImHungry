// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
var visibleDiv = 0;

function showDiv() {
    $(".restaurant").hide();
    $(".restaurant1").hide();
    $(".restaurant:eq(" + visibleDiv + ")").show();
}

function showNext() {
    if (visibleDiv == $(".restaurant").length - 1) {
        visibleDiv = 0;
    } else {
        visibleDiv++;
    }
    showDiv();
}
function showPrev() {
    if (visibleDiv == 0) {
        visibleDiv = $(".restaurant").length - 1;
    } else {
        visibleDiv--;
    }
    showDiv();
}