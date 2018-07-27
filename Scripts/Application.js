function Appli() {
    var formData = {
        "Custname": $("#name").val(),
        "EmployerName": $("#employer_name").val(),
        "LifeInsuranceName": $("#insurance_name").val(),
        "Custphone": $("#phoneNumber").val(),
        "Custaddress": $("#address").val()
    }
    $.ajax({
        url: "api/MBRs",
        type: "POST",
        data: formData,
        dataType: 'json',

        success: function (data) {
            alert("data:" + data)
            alert("data.applicationid:" + data.applicationid)
        }
    });
    return true;
}