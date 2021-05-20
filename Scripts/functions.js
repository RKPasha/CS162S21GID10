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
