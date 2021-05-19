function test() {
alert("Anni deya yad rakhna si naa Password🙄!!!");
}

function goToCeoPage() {
    alert("CEO credentials entered");
    //location.href='/CEO/Index';
    window.open('/CEO/Index'); return true;
}

function goToManagerPage() {
    location.href('/Manager/Index');
    alert("Manager credentials entered");
}

function goToUserPage() {
    //location.href('/CEO/Index');
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