 
// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(function() {
    $('#loaderbody').addClass('hide');

    $(document).bind("ajaxStart", function () {
        $('#loaderbody').removeClass('hide');
    }).bind("ajaxStop" , function () {
        $('#loaderbody').addClass('hide');
    });
});
showInPopup = (url, title) => {
    debugger;
    $.ajax({
        type: "GET",
        url: url,
        success: function (res) {
            $("#form-modal .modal-body").html(res);
            $("#form-modal .modal-title").html(title);
            $("#form-modal").modal('show');
        },
        error: function (xhr) {
            if (xhr.status === 401) {
                // Session expired or not authorized
                window.location.href = '/Identity/Account/Login';
            } else {
                alert("An error occurred while loading the form.");
            }
        }
    });
}

jQueryAjaxPost = form => {
    try {
        $.ajax({
            type: "POST",
            url: form.action,
            data: new FormData(form),
            contentType: false,
            processData: false,
            success: function (res) {
                if (res.isValid) {
                    $("#view-all").html(res.html);
                    $("#form-modal .modal-body").html('');
                    $("#form-modal .modal-title").html('');
                    $('#form-modal').modal('hide');
                    $.notify("Submitted Successfully", { globalPosition: "top centre", className:"Success" });
                }
                else {
                    $("#form-modal .modal-body").html(res.html);

                }
            },
            error: function (err) {

                console.log(err);
            }
        });
    }
    catch (e) {
        console.log(e);
    }
    return false;
}

jQueryAjaxDelete = form => {
    if (confirm('Are you sure to this record?')) {
        try {
            $.ajax({
                type: "POST",
                url: form.action,
                data: new FormData(form),
                contentType: false,
                processData: false,
                success: function (res) {
                    $("#view-all").html(res.html);
                    $.notify("Deleted Successfully", { globalPosition: "top centre", className:"Success" });

                },
                error: function (err) {
                    console.log(err);
                }
            });
        }
        catch (e) {
            console.log(e);
        }
    }
    return false;
}

document.addEventListener("DOMContentLoaded", function () {
    const sidebarToggle = document.getElementById("sidebarToggle");
    const wrapper = document.getElementById("wrapper");

    if (sidebarToggle) {
        sidebarToggle.addEventListener("click", function (e) {
            e.preventDefault();
            wrapper.classList.toggle("toggled");
        });
    }
});