function checkData() {
    var email = document.getElementById("dnEmail").value;
    var pass = document.getElementById("dnPass").value;
    var erEmail = document.getElementById("error_email");
    var erPass = document.getElementById("error_pass");
    var ok = true;

    if (email == "") {
        erEmail.innerHTML = "* email không được rỗng";
        ok = false;
    } else {
        erEmail.innerHTML = "";
    }

    if (pass == "") {
        erPass.innerHTML = "* Password không được rỗng";
        ok = false;
    } else {
        erPass.innerHTML = "";
    }

    return ok;
}