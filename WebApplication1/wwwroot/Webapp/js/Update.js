$(document).ready(function () {
 
    $("#btnUpdateMake").click(function () {
        alert("Update");
        var makeName = $("#makeName").val();
        if (makeName == null || makeName == undefined || makeName == "") {
            $("#errorUpdateMake").html("please enter make name").css("color", "red");
            return false;
        }
    });
})