// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
var visibleDiv = 0;
var lat = parseFloat(document.getElementById(visibleDiv.toString()).innerHTML);
var lng = parseFloat(document.getElementById(visibleDiv.toString() + " lng").innerHTML);

function newLocation(newLat, newLng) {
    ({
        lat: newLat,
        lng: newLng
    });
}


function showDiv() {
    $(".restaurant").hide();
    $(".restaurant1").hide();
    $(".restaurant:eq(" + visibleDiv + ")").show();


}

function showNext() {
    if (visibleDiv == $(".restaurant").length - 1) {
        visibleDiv = 0;
        lat = parseFloat(document.getElementById(visibleDiv.toString()).innerHTML);
        lng = parseFloat(document.getElementById(visibleDiv.toString() + " lng").innerHTML);
    } else {
        visibleDiv++;
         lat = parseFloat(document.getElementById(visibleDiv.toString()).innerHTML);
         lng = parseFloat(document.getElementById(visibleDiv.toString() + " lng").innerHTML);

    }

    showDiv();
}
function showPrev() {
    if (visibleDiv == 0) {
        visibleDiv = $(".restaurant").length - 1;
        lat = parseFloat(document.getElementById(visibleDiv.toString()).innerHTML);
        lng = parseFloat(document.getElementById(visibleDiv.toString() + " lng").innerHTML);
        
    } else {
        visibleDiv--;
        lat = parseFloat(document.getElementById(visibleDiv.toString()).innerHTML);
        lng = parseFloat(document.getElementById(visibleDiv.toString() + " lng").innerHTML);
        
    }
    showDiv();
}

var map;
function initMap() {



    map = new google.maps.Map(document.getElementById('map'), {
        center: {
            lat: lat, lng: lng
        },
        zoom: 15


    });
    var marker = new google.maps.Marker({
        position: { lat: lat, lng: lng },
        map: map,
        title: ''

    });


}