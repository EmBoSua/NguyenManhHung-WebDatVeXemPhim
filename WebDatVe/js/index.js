var kichThuoc = document.getElementsByClassName("slide")[0].clientWidth;
var chuyenSlide = document.getElementsByClassName("chuyen-slide")[0];
var chuyen = 0;
var Img = chuyenSlide.getElementsByTagName("img");
var Max = kichThuoc * Img.length;
Max -= kichThuoc;

function Next() {
    if (chuyen < Max) {
        chuyen += kichThuoc;
    } else {
        chuyen = 0;
    }

    chuyenSlide.style.marginLeft = '-' + chuyen + 'px';
}

function Back() {
    if (chuyen == 0) {
        chuyen = Max;
    } else {
        chuyen -= kichThuoc;
    }

    chuyenSlide.style.marginLeft = '-' + chuyen + 'px';
}

// auto chay
setInterval(function () {
    //cong viec can lam
    Next();
}, 3000) // cu 3s next anh










































//var sdt = document.getElementById("sdt").value;
//var number_sdt = Number(sdt);
/*else if (Number.isNaN(number_sdt)) {
    dulieu = false;
    document.getElementById("ck_sdt").innerHTML = "Dự liệu nhập vào phải là số!";

}*/
        //check có số 0 đầu và 10 số
    //else if (sdt.charAt(0) != 0 || sdt.length != 10) {
    //    document.getElementById("ck_sdt").innerHTML = "Số điện thoại bạn nhập sai";
    //    dulieu = false;
    //}





//var filter = /^([#?!@$%^&*-])+([a-zA-Z0-9_\.\-])+$/;
//var filter = /^([A-Z])+([a-zA-Z0-9_\.\-])+$/;
    //check mật khẩu 8 kí tự
    //else if (matkhau.length < 8) {
    //    document.getElementById("ck_matkhau").innerHTML = "Bạn cần nhập mật khẩu 8 kí tự ";

    //    dulieu = false;
    //} 

        //check chữ hoa
    //else if (!filter.test(pass)) {
    //    document.getelementbyid("ck_matkhau").innerhtml = "nhập mật khẩu phải có chữ hoa";
    //    dulieu = false;
    //}

//check kí tự đặc biệt
    //else if (!filter.test(pass)) {
    //    document.getElementById("ck_matkhau").innerHTML = "Nhập mật khẩu phải có ký đặc biệt";
    //    dulieu = false;
    //}





/*var cE = checkEmail(email);

if (ok == true && cE == true) {
    return true
} else {
    return false;
}

// kiem tra dinh dang email
function checkEmail(the_email) {
    var a = the_email.indexOf("@");
    var cham = the_email.lastIndexOf(".");
    var cach = the_email.indexOf(" ");

    if ((a != -1) && //có ký tự @
        (a != 0) && //ký tự @ không nằm ở vị trí đầu
        (cham != -1) && //có ký tự .
        (cham > a + 1) &&
        (cham < the_email.length - 1) &&//phải có ký tự nằm giữa @ và . cuối cùng
        (cach == -1)) //không có khoẳng trắng 
    {
        return true;
    } else {
        document.getElementById("error_email").innerHTML = "* Email sai dinh dang.";
        return false;
    }
}*/