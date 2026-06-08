function SaveCForm() {

    var model = {

        DevoteeId: $('#CFormDevoteeId').val(),

        FirstName: $('#FirstName').val(),
        LastName: $('#LastName').val(),
        Sex: $('#Sex').val(),
        DOB: $('#DOB').val(),
        SpecialCategory: $('#SpecialCategory').val(),
        Nationality: $('#Nationality').val(),

        Address: $('#Address').val(),
        City: $('#City').val(),
        Country: $('#Country').val(),

        PassportNo: $('#PassportNo').val(),
        PassportIssue: $('#PassportIssue').val(),
        PassportExpiry: $('#PassportExpiry').val(),

        VisaNumber: $('#VisaNumber').val(),
        VisaType: $('#VisaType').val(),
        VisaSubType: $('#VisaSubType').val(),
        VisaCity: $('#VisaCity').val(),
        VisaCountry: $('#VisaCountry').val(),

        ArrivedFromCountry: $('#ArrivedFromCountry').val(),
        ArrivedFromCity: $('#ArrivedFromCity').val(),
        ArrivalIndia: $('#ArrivalIndia').val(),
        ArrivalAshram: $('#ArrivalAshram').val(),
        ArrivalTime: $('#ArrivalTime').val(),
        Duration: $('#Duration').val(),

        Purpose: $('#Purpose').val(),
        Remarks: $('#Remarks').val()
    };
    debugger;
    $.ajax({

        url: '/CForm/Save',
        type: 'POST',
        contentType: 'application/json charset=utf-8',
        data: JSON.stringify(model),

        success: function (response) {

            Swal.fire({
                icon: 'success',
                title: 'Saved Successfully',
                timer: 1500,
                showConfirmButton: false
            });

            LoadCFormStatus();
        },

        error: function (xhr) {

            Swal.fire({
                icon: 'error',
                title: 'Error',
                text: 'Error saving C-Form'
            });

            console.error(xhr);

        }

    });
}
function LoadCForm() {

    $.get('/CForm/Get?devoteeId=' + $('#CFormDevoteeId').val(),
        function (data) {

            if (!data) return;

            $('#FirstName').val(data.firstName);
            $('#LastName').val(data.lastName);
            $('#Sex').val(data.sex);
            $('#DOB').val(data.dob);

            $('#Nationality').val(data.nationality);

            $('#Address').val(data.address);
            $('#City').val(data.city);
            $('#Country').val(data.country);

            $('#PassportNo').val(data.passportNo);
            $('#VisaNumber').val(data.visaNumber);

        });
}

function ValidateCForm() {

    var errors = [];

    if (!$('#FirstName').val())
        errors.push("First Name required");

    if (!$('#LastName').val())
        errors.push("Last Name required");

    if (!$('#Sex').val())
        errors.push("Sex required");

    if (!$('#DOB').val())
        errors.push("DOB required");

    if (!$('#Nationality').val())
        errors.push("Nationality required");

    if (!$('#PassportNo').val())
        errors.push("Passport No required");

    if (!$('#VisaNumber').val())
        errors.push("Visa Number required");

    if (!$('#ArrivalIndia').val())
        errors.push("Arrival in India required");

    if (!$('#ArrivalAshram').val())
        errors.push("Arrival in Ashram required");

    return errors;
}

function PrintCForm() {

    var errors = ValidateCForm();

    if (errors.length > 0) {

        var html = "<ul>";

        errors.forEach(function (e) {
            html += "<li>" + e + "</li>";
        });

        html += "</ul>";

        Swal.fire({
            icon: 'error',
            title: 'Missing Fields',
            html: html
        });

        return;
    }

    SaveCForm();

    window.open('/CForm/Print?devoteeId=' + $('#CFormDevoteeId').val(),
        '_blank');

}