function saveData() {
    alert("Function called");
    var name = $("#name").val();
    var dob = $("#dob").val();
    var email = $("#email").val();
    var contactNo = $("#contactNo").val();
    var password = $("#password").val();
    var obj = {
        Name: name,
        Email: email,
        ContactNumber: contactNo,
        DateOfBirth: dob,
        Password: password
    }
    console.log(obj);

    $.ajax({
        url: 'https://localhost:44304/api/UserAPI/AddUser',
        type: 'POST',
        data: JSON.stringify(obj),
        contentType: "application/json;charset-utf-8",
        success: function (response) {
            alert(response);
        },
        error: function (response) {
            alert(response);
        }
    })
}
function hello() {
    alert("hello!");
}
