function nullIfEmpty(value) {
    return value === "" ? null : value;
}
function SaveCForm() {
    var model = {

        DevoteeId: parseInt($('#CFormDevoteeId').val()),
        CreatedDate: parseInt($('#CreatedDate').val()),

        FirstName: $('#FirstName').val(),
        LastName: $('#LastName').val(),
        Sex: nullIfEmpty($('Sex').val()),
        DOB: nullIfEmpty($('#DOB').val()),
        DurationOfStay: nullIfEmpty($('#DurationOfStay').val()),
        IsEmployedInIndia: nullIfEmpty($('#IsEmployedInIndia').val()),
        NextDestination: nullIfEmpty($('#NextDestination').val()),
        DateOfArrivalInIndia: nullIfEmpty($('#DateOfArrivalInIndia').val()),
        DateOfArrivalInAnandAshram: nullIfEmpty($('#DateOfArrivalInAnandAshram').val()),
        TimeOfArrivalInAnandAshram: nullIfEmpty($('#TimeOfArrivalInAnandAshram').val()),
        PassportDateOfIssue: nullIfEmpty($('#PassportDateOfIssue').val()),
        PassportDateOfExpiry: nullIfEmpty($('#PassportDateOfExpiry').val()),

        VisaDateOfIssue: nullIfEmpty($('#VisaDateOfIssue').val()),

        VisaDateOfExpiry: nullIfEmpty($('#VisaDateOfExpiry').val()),

        SpecialCategory: nullIfEmpty($('#SpecialCategory').val()),
        Nationality: $('#Nationality').val(),

        Address: $('#Address').val(),
        City: $('#City').val(),
        Country: $('#Country').val(),

        ReferenceAddress: $('#ReferenceAddress').val(),
        ReferenceState: $('#ReferenceState').val(),
        ReferenceCity: $('#ReferenceCity').val(),
        ReferencePincode: $('#ReferencePincode').val(),

        PassportNo: $('#PassportNo').val(),

        VisaNumber: $('#VisaNumber').val(),
        VisaCity: $('#VisaCity').val(),
        VisaCountry: $('#VisaCountry').val(),
        VisaType: $('#VisaType').val(),
        VisaSubType: $('#VisaSubType').val(),

        ArrivedFromCountry: $('#ArrivedFromCountry').val(),
        ArrivedFromCity: $('#ArrivedFromCity').val(),

        ArrivedFromPlaceInIndia: $('#ArrivedFromPlaceInIndia').val(),

        PurposeOfVisit: $('#PurposeOfVisit').val(),

        DestinationCountry: $('#DestinationCountry').val(),
        DestinationState: $('#DestinationState').val(),
        DestinationCity: $('#DestinationCity').val(),

        Place: $('#Place').val(),

        ContactPhoneNumber: $('#ContactPhoneNumber').val(),
        MobileNumber: $('#MobileNumber').val(),

        PermanentCountryPhone: $('#PermanentCountryPhone').val(),
        PermanentCountryMobile: $('#PermanentCountryMobile').val(),

        Remarks: $('#Remarks').val()
    };

    $.ajax({

        url: '/CForm/Save',
        type: 'POST',
        contentType: "application/json; charset=utf-8",
        data: JSON.stringify(model),

        success: function () {
            alert("Saved successfully");
        },

        error: function (err) {
            console.log(err);
        }

    });

}

function LoadCForm() {

    $.get('/CForm/Get?devoteeId=' + $('#CFormDevoteeId').val(),
        function (data) {

            if (!data)
                return;

            $('#FirstName').val(data.firstName);
            $('#LastName').val(data.lastName);
            $('#Sex').val(data.sex);
            $('#DOB').val(data.dob);
            $('#CreatedDate').val(data.createdDate);

            $('#DurationOfStay').val(data.durationOfStay);
            $('#IsEmployedInIndia').val(data.isEmployedInIndia);
            $('#NextDestination').val(data.nextDestination);

            $('#DateOfArrivalInIndia').val(data.dateOfArrivalInIndia?.substring(0, 10));
            $('#DateOfArrivalInAnandAshram').val(data.dateOfArrivalInAnandAshram?.substring(0, 10));

            $('#TimeOfArrivalInAnandAshram').val(data.timeOfArrivalInAnandAshram);

            $('#PassportDateOfIssue').val(data.passportDateOfIssue?.substring(0, 10));
            $('#PassportDateOfExpiry').val(data.passportDateOfExpiry?.substring(0, 10));

            $('#VisaDateOfIssue').val(data.visaDateOfIssue?.substring(0, 10));
            $('#VisaDateOfExpiry').val(data.visaDateOfExpiry?.substring(0, 10));

            $('#SpecialCategory').val(data.specialCategory);

            $('#Nationality').val(data.nationality);

            $('#Address').val(data.address);
            $('#City').val(data.city);
            $('#Country').val(data.country);

            $('#ReferenceAddress').val(data.referenceAddress);
            $('#ReferenceState').val(data.referenceState);
            $('#ReferenceCity').val(data.referenceCity);
            $('#ReferencePincode').val(data.referencePincode);

            $('#PassportNo').val(data.passportNo);

            $('#VisaNumber').val(data.visaNumber);
            $('#VisaCity').val(data.visaCity);
            $('#VisaCountry').val(data.visaCountry);
            $('#VisaType').val(data.visaType);
            $('#VisaSubType').val(data.visaSubType);

            $('#ArrivedFromCountry').val(data.arrivedFromCountry);
            $('#ArrivedFromCity').val(data.arrivedFromCity);

            $('#ArrivedFromPlaceInIndia').val(data.arrivedFromPlaceInIndia);

            $('#PurposeOfVisit').val(data.purposeOfVisit);

            $('#DestinationCountry').val(data.destinationCountry);
            $('#DestinationState').val(data.destinationState);
            $('#DestinationCity').val(data.destinationCity);

            $('#Place').val(data.place);

            $('#ContactPhoneNumber').val(data.contactPhoneNumber);
            $('#MobileNumber').val(data.mobileNumber);

            $('#PermanentCountryPhone').val(data.permanentCountryPhone);
            $('#PermanentCountryMobile').val(data.permanentCountryMobile);

            $('#Remarks').val(data.remarks);
        });
}

function addError(errors, selector, fieldName) {

    if (!$(selector).val())
        errors.push(fieldName);

}

function ValidateCForm() {

    var personalErrors = [];
    var passportErrors = [];
    var arrivalErrors = [];

    // PERSONAL TAB

    addError(personalErrors, '#FirstName', 'First Name');
    addError(personalErrors, '#LastName', 'Last Name');
    addError(personalErrors, '#SexList', 'Sex');
    addError(personalErrors, '#DOB', 'Date of Birth');
    addError(personalErrors, '#SpecialCategory', 'Special Category');
    addError(personalErrors, '#Nationality', 'Nationality');

    addError(personalErrors, '#Address', 'Address');
    addError(personalErrors, '#City', 'City');
    addError(personalErrors, '#Country', 'Country');

    addError(personalErrors, '#ReferenceAddress', 'Reference Address');
    addError(personalErrors, '#ReferenceState', 'Reference State');
    addError(personalErrors, '#ReferenceCity', 'Reference City');
    addError(personalErrors, '#ReferencePincode', 'Reference Pincode');


    // PASSPORT TAB

    addError(passportErrors, '#PassportNo', 'Passport Number');
    addError(passportErrors, '#PassportDateOfIssue', 'Passport Date Of Issue');
    addError(passportErrors, '#PassportDateOfExpiry', 'Passport Date Of Expiry');

    addError(passportErrors, '#VisaNumber', 'Visa Number');
    addError(passportErrors, '#VisaCity', 'Visa City');
    addError(passportErrors, '#VisaCountry', 'Visa Country');
    addError(passportErrors, '#VisaDateOfIssue', 'Visa Date Of Issue');
    addError(passportErrors, '#VisaDateOfExpiry', 'Visa Date Of Expiry');
    addError(passportErrors, '#VisaType', 'Visa Type');

        // ARRIVAL TAB

    addError(arrivalErrors, '#ArrivedFromCountry', 'Arrived From Country');
    addError(arrivalErrors, '#ArrivedFromCity', 'Arrived From City');

    addError(arrivalErrors, '#DateOfArrivalInIndia', 'Date Of Arrival In India');

    addError(arrivalErrors, '#ArrivedFromPlaceInIndia', 'Arrived From Place In India');

    addError(arrivalErrors, '#DateOfArrivalInAnandAshram', 'Date Of Arrival In Anand Ashram');
    addError(arrivalErrors, '#TimeOfArrivalInAnandAshram', 'Time Of Arrival In Anand Ashram');

    addError(arrivalErrors, '#DurationOfStay', 'Duration Of Stay');

    addError(arrivalErrors, '#IsEmployedInIndia', 'Employment Status');

    addError(arrivalErrors, '#PurposeOfVisit', 'Purpose Of Visit');

    addError(arrivalErrors, '#NextDestination', 'Next Destination');

    addError(arrivalErrors, '#DestinationCountry', 'Destination Country');
    addError(arrivalErrors, '#DestinationState', 'Destination State');
    addError(arrivalErrors, '#DestinationCity', 'Destination City');

    addError(arrivalErrors, '#Place', 'Place');

    addError(arrivalErrors, '#ContactPhoneNumber', 'Contact Phone');
    addError(arrivalErrors, '#MobileNumber', 'Mobile Number');

    addError(arrivalErrors, '#PermanentCountryPhone', 'Permanent Country Phone');
    addError(arrivalErrors, '#PermanentCountryMobile', 'Permanent Country Mobile');

    //addError(arrivalErrors, '#Remarks', 'Remarks');

    return {
        personal: personalErrors,
        passport: passportErrors,
        arrival: arrivalErrors
    };
}

function PrintCForm() {

    var validation = ValidateCForm();

    var html = '';

    if (validation.personal.length > 0) {

        html += '<b>Personal Tab</b><ul>';

        validation.personal.forEach(function (e) {
            html += '<li>' + e + '</li>';
        });

        html += '</ul>';
    }

    if (validation.passport.length > 0) {

        html += '<b>Passport & Visa Tab</b><ul>';

        validation.passport.forEach(function (e) {
            html += '<li>' + e + '</li>';
        });

        html += '</ul>';
    }

    if (validation.arrival.length > 0) {

        html += '<b>Arrival & Departure Tab</b><ul>';

        validation.arrival.forEach(function (e) {
            html += '<li>' + e + '</li>';
        });

        html += '</ul>';
    }

    if (html !== '') {

        Swal.fire({
            icon: 'error',
            title: 'Missing Fields',
            html: html
        });

        // Move user to first invalid tab

        if (validation.personal.length > 0) {

            bootstrap.Tab.getOrCreateInstance(
                document.getElementById('personal-tab')
            ).show();

        }
        else if (validation.passport.length > 0) {

            bootstrap.Tab.getOrCreateInstance(
                document.getElementById('passport-tab')
            ).show();

        }
        else {

            bootstrap.Tab.getOrCreateInstance(
                document.getElementById('arrival-tab')
            ).show();

        }

        return;
    }

    SaveCForm();

    window.open(
        '/CForm/Print?devoteeId=' + $('#CFormDevoteeId').val(),
        '_blank'
    );
}