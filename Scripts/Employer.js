function GetEmployeData() {
    var formData = {
      // employee ID
        "employeeId": $("#employeeId").val()
    }
    $.ajax({
        url: "/Employers/GetEmployer" + formData.employeeId,
        type: "GET",
        data: formData,
        dataType: 'json',

        success: function (data) {
            //alert("data:" + data)
            //alert("data.salary:" + data.Employeesalary)

            PutEmployeeData(data)
        }
    });


    return false;
}

function PutEmployeeData(data1) {
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
            
            alert("employee salary:" + data1.Employeesalary)
        }
    });
}