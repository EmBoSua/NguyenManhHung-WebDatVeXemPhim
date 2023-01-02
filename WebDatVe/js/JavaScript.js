function checkInfor() {
    var ten = document.getElementById("Ten").value;
    var email = document.getElementById("Email").value;
    var sdt = document.getElementById("SDT").value;
    var pass = document.getElementById("Pass").value;
    var cfpass = document.getElementById("ComfirmPass").value;
    var erTen = document.getElementById("error_ten");
    var erEmail = document.getElementById("error_email");
    var erSDT = document.getElementById("error_sdt");
    var erPass = document.getElementById("error_pass");
    var erCFPassr = document.getElementById("error_confirm");
    var cb = document.getElementById("DieuKhoan").checked;
    var lb = document.getElementById("lbCheckBox");

    var ok = true;

    if (ten == "") {
        erTen.innerHTML = "* Tên không được rỗng";
        ok = false;
    } else {
        erTen.innerHTML = "";
    }

    if (email == "") {
        erEmail.innerHTML = "* email không được rỗng";
        ok = false;
    } else {
        erEmail.innerHTML = "";
    }

    if (sdt == "") {
        erSDT.innerHTML = "* SDT không được rỗng";
        ok = false;
    } else {
        erSDT.innerHTML = "";
    }
    if (sdt.length < 9 || sdt.length > 11) {
        erSDT.innerHTML = "* SDT tu 9 den 11 so";
        ok = false;
    }
    else {
        erSDT.innerHTML = "";
    }

    if (pass == "") {
        erPass.innerHTML = "* Password không được rỗng";
        ok = false;
    } else {
        erPass.innerHTML = "";
    }

    if (cfpass == "") {
        erCFPassr.innerHTML = "* Confir password không được rỗng";
        ok = false;
    } else {
        erCFPassr.innerHTML = "";
    }

    if (ok) {
        if (pass != cfpass) {
            erCFPassr.innerHTML = "* Confir password không giống Password";
            ok = false;
        } else {
            erCFPassr.innerHTML = "";
        }
    }

    if (!cb) {
        lb.style.color = "red";
        ok = false;
    } else {
        lb.style.color = "black";
    }

    return ok;
}




function test() {
    var ten = document.getElementById("Ten").value;
    var erTen = document.getElementById("error_ten");
    erTen.innerHTML = "* Tên không được rỗng";

    if (ten == "") {
        erTen.innerHTML = "* Tên không được rỗng";
        return false;
    } else {
        return true;
        erTen.innerHTML = "";
    }

}