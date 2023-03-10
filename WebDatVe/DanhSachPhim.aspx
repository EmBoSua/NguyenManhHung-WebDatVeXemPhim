<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DanhSachPhim.aspx.cs" Inherits="v2.DanhSachPhim" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/df.css" rel="stylesheet" />
    <link href="css/id.css" rel="stylesheet" />
</head>
<body>
    <!-- logo va dang ky/ dang nhap -->
    <div class="khung-logo-dk-dn" style="background-image: url(anh/logo/bg.png);">
        <a class="logo" href="/index.aspx"><img src="anh/logo/logoCGV.png" alt=""></a>
        <div class="khung-dn-dk-dx">
            <div class="dk-dn" id="tenUser" runat="server">
                <a href="/DangKy.aspx">Đăng Ký</a> | 
                <a href="/DangNhap.aspx">Đăng Nhập</a>
            </div>
            
            <div class="out" runat="server" id="out_div">
                <a href="DangXuat.aspx">
                    <p class="out-show">Đăng xuất</p>
                </a>
            </div>
        </div>
        
    </div>

    <!-- menu chinh -->

    <div id="menu">
        <ul>
            <li><a href="/index.aspx" title="Trang chủ">Trang chủ</a></li>
            <li><a href="/RapPhim.aspx" title="Rạp">Rạp</a></li>
            <li><a href="/DanhSachPhim.aspx" title="Phim">Phim</a></li>
            <li><a href="/VeCuaToi.aspx" title="Vé của tôi">Vé của tôi</a></li>
        </ul>  
    </div>

    <!-- content -->

    <div class="content">
        <div class="moveSelection" id ="moveSelection" runat ="server">
            
        </div>
    </div>
    
    <!-- footer -->
    <div class="footer">
        <div class="footerItem gioiThieu">
            <h3>CGV Việt Nam</h3>
            <ul>
                <li><a href="#">Giới thiệu</a></li>
                <li><a href="#">Quà tặng</a></li>
                <li><a href="#">Tiện dụng</a></li>
                <li><a href="#">Điều khoản chung</a></li>
            </ul>
        </div>
        <div class="footerItem ketNoi">
            <h3>Kết nối với CGV</h3>
            <ul>
                <li><a href="#"><div class="knAnh"><img src="anh/footer/facebook.png" alt=""/></div></a></li>
                <li><a href="#"><div class="knAnh"><img src="anh/footer/instagram.png" alt=""/></div></a></li>
                <li><a href="#"><div class="knAnh"><img src="anh/footer/twitter.png" alt=""/></div></a></li>
            </ul>
        </div>
        <div class="footerItem lienHe">
            <h3>Chăm sóc khách hàng</h3>
            <ul>
                <li><a href="#">Số điện thoại: 0123456789</a></li>
                <li><a href="#">Giờ làm việc: 8:00 - 22:00</a></li>
                <li><a href="#">Email hỏi đáp: hoidap@cgv.vn</a></li>
            </ul>
        </div>
    </div>
</body>
</html>
