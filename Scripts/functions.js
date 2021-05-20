function test() {
alert("Anni deya yad rakhna si naa Password🙄!!!");
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