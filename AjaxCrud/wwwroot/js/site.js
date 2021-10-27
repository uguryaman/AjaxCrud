// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


$(function () {
    $("#ok").click(function () {
        $("*").hide();
    });
});

$(function () {
    $(".warning").click(function () {
        $("*").hide();
    });
})

showInPopup=(url, title)=>{
    $.ajax({
        type:"GET", 
        url: url,
        success: function (res) {
            $("#form-modal .modal-title").html(title);
            $("#form-modal .modal-body").html(res);
            $("#form-modal").modal('show');
        }

    })
}