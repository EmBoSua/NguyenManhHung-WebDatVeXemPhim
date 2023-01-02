<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TrangChiTiet.aspx.cs" Inherits="v2.TrangChiTiet" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/df.css" rel="stylesheet" />
    <link href="css/trangChiTiet.css" rel="stylesheet" />
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
        <div>
            <div class="Layout" id="thonTinPhim" runat="server">
                
            </div>
        </div>

        
        <div class="ctDongKe3">
            <hr />
            <h2 class="tieuDeMuc"> Phim Khac</h2>
        </div>
        <div class="moveSelection" id="moveSelection" runat="server">

        </div>
    </div>



    <!-- footer -->
    <div class="footer">
        <div class="footerItem gioiThieu">
            <h3>CGV Viet Nam</h3>
            <ul>
                <li><a href="#">Gioi thieu</a></li>
                <li><a href="#">Qua tang</a></li>
                <li><a href="#">Tien dung</a></li>
                <li><a href="#">Dieu khoan chung</a></li>
            </ul>
        </div>
        <div class="footerItem ketNoi">
            <h3>Ket noi voi chung toi</h3>
            <ul>
                <li><a href="#"><div class="knAnh"><img src="anh/footer/facebook.png" alt=""/></div></a></li>
                <li><a href="#"><div class="knAnh"><img src="anh/footer/instagram.png" alt=""/></div></a></li>
                <li><a href="#"><div class="knAnh"><img src="anh/footer/twitter.png" alt=""/></div></a></li>
            </ul>
        </div>
        <div class="footerItem lienHe">
            <h3>Cham soc khach hang</h3>
            <ul>
                <li><a href="#">So dien thoai: 0123456789</a></li>
                <li><a href="#">Gio lam viec: 8:00 - 22:00</a></li>
                <li><a href="#">Email ho tro: hoidap@cgv.vn</a></li>
            </ul>
        </div>
    </div>
</body>
</html>
