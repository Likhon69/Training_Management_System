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

//var Name_Error_Message = false;
//var RegNo_Error_Message = false;
$("#document").ready(function () {
    $("#Name").focusout(function () {
        var Name_Length = $("#Name").val().length;
        if (Name_Length == '') {
            $("#Name_Error_Message").html("Please Fill the Name");
            $('#Name_Error_Message').css("color", "red");
            //$("#Name_Error_Message").show();
            //Name_Error_Message = true;
        } else if (Name_Length < 5 || Name_Length > 20) {
            $("#Name_Error_Message").html("Should be 5-20 Characters")
        } else {
            ("#Name_Error_Message").hide();
        }

    });
    $("#RegNo").focusout(function () {
        var Reg_Length = $("#RegNo").val().length;
        if (Reg_Length == '') {
            $("#RegNo_Error_Message").html("Please Fill The Registration");
            $('#RegNo_Error_Message').css("color", "red");
            //$("#Name_Error_Message").show();
            //Name_Error_Message = true;
        } else {
            $("#RegNo_Error_Message").hide();
        }

    });
    $("#Email").focusout(function () {
        var email = $("#Email").val();
        var reg = /^([a-zA-Z0-9_.+-])+\@(([a-zA-Z0-9-])+\.)+([a-zA-Z0-9]{2,4})+$/;
        if (reg.test(email)) {
            $("#Email").css("border", "2px solid green");
            $("#Email_Error_Message").html("Success");
        } else {
            $("#Email_Error_Message").hide("Success");
            $("#Email").css("border", "2px solid red");
        }
    });
    $("#Address").focusout(function () {
        var address = $("#Address").val().length;
        if (address == '') {
            $("#Address_Error_Message").html("Please fill the Address");
            $("#Address_Error_Message").css("color", "red");
            $("Address").css("border", "2px solid red")
        } else {
            $("#Address_Error_Message").hide();
            $("#Address").css("border","2px solid green");
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
