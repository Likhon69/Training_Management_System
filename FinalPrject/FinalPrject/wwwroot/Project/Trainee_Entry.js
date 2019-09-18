$(document).ready(function () {

    $.ajax({
        url: "/trainee/GetAllDepartmentJsonResult",
        success: function (response) {
            var departments = response;

            $.each(departments,
                function (key, department) {
                    var option = "<option value='" + department.Id + "'>" + department.DeptName + "</option>";
                    $('#DepartmentId').append(option);
                });


        }
    });


});

$('#DepartmentId').change(function () {
    var DepartmentDD = $('#DepartmentId');
    var departmentId = DepartmentDD.val();
    var Jasondata = { departmentId: departmentId }
    $.ajax({
        url: "https://localhost:44391/trainee/getByDepartmentPartial",
        type: "GET",
        data: Jasondata,
        contentType: "application/json",
        success: function (response) {
            $('#div_trainilist').html(response);
        }
    });
});
