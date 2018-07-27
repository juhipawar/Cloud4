function GetInsurance() {
    var formData = {
        // employee ID
        "InsuranceId": $("#InsuranceId").val()
    }
    $.ajax({
        url: "/Insurances/GetInsurance" + formData.employeeId,
        type: "GET",
        data: formData,
        dataType: 'json',

        success: function (data) {
            //alert("data:" + data)
            //alert("data.salary:" + data.Employeesalary)

            PutInsuranceData(data)
        }
    });


    return false;
}

function PutInsuranceData(data1) {
    var formData = {
        // applicationId from UI
        "applicationId": $("#applicationId").val()
    }
    $.ajax({
        url: "/MBRs/PutMBR/" + formData.applicationId,
        type: "PUT",
        data: data1,
        dataType: 'json',

        success: function () {

            alert("InsurancePolicyNumber :" + data1.InsurancePolicyNumber)
            alert("Insurancevalue :" + data1.Insurancevalue)

        }
    });
}