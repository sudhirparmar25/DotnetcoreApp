$(document).ready(function () {
 
    $("#btnAddMake").click(function () {
        alert("Add");
        var makeName = $("#makeName").val();
        if (makeName == null || makeName == undefined || makeName == "") {
            $("#errorAddMake").html("please enter make name").css("color", "red");
            return false;
        }
    });
})