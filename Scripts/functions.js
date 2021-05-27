function test() {
alert("Anni deya yad rakhna si naa Password🙄!!!");
}

function goToMainPage() {
    alert("good ho gya g");
    window.location = '/Home/Index';
}
function goToCeoPage() {
    window.location='/CEO/Index';
}

function goToManagerPage() {
    window.location = '/Manager/Index';
}

function goToUserPage() {
    alert("User Login");
}
function Login() {
    var email = document.getElementById("email").value;
    var password = document.getElementById("password").value;

    if (email === "ceo@duko.com" && password === "ceo") {
           
        goToCeoPage();
    } else if (email === "manager@duko.com" && password === "manager") {
        goToManagerPage();
    } else if (email === "user@duko.com" && password === "user") {
        goToUserPage();
    } else {
        alert("User Not Found!!");
    }
}

function LogOut() {
    alert("jaja turr ja");
    //document.getElementById("email").value = "";
    //document.getElementById("password").value = "";
    goToMainPage();

}


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
        ConactNumber: contactNo,
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
