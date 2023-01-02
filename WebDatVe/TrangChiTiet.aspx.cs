using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace v2
{
    public partial class TrangChiTiet : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //kiem tra xem da dang nhap chua va hien ten dang nhap
            if ((string)Session["tenUser"] != null)
            {
                tenUser.InnerText = (string)Session["tenUser"];
                out_div.Attributes.Remove("class");
            }

            // lay id phim da chon
            string idPhim = Request.QueryString.Get("IDPhim");

            // lay danh sach phim
            List<phim> f = (List<phim>)Application["listPhim"];

            string trP = "";
            foreach(phim i in f)
            {
                if(i.Id == idPhim)
                {
                    trP = "<h2 class='tenPhim1'>"+i.Ten+"</h2>"
                        +"<hr>"
                        +"<div class='chiTietPhim'>"
                            +"<div class='anhPhim'>"
                                +"<img src='"+i.Anh+"' alt='anh loi'>"
                            +"</div>"
                            +"<div class='content2'>"
                                +"<div>"
                                    +"<h3>"+i.Ten+"</h3>"
                                    +"<hr>"
                                +"</div>"
                                +"<div>"
                                    +"<div class='table'>"
                                        +"<div>"
                                            +"<p class='chiMuc'>Dao dien</p>"
                                            +"<p class='noiDung'>"+i.DaoDien+"</p>"
                                        +"</div>"
                                        +"<div>"
                                            +"<p class='chiMuc'>Dien vien</p>"
                                            +"<p class='noiDung'>"+i.DienVien+"</p>"
                                        +"</div>"
                                        +"<div>"
                                            +"<p class='chiMuc'>The loai</p>"
                                            + "<p class='noiDung'>"+i.TheLoai+"</p>"
                                         + "</div>"
                                        +"<div>"
                                            +"<p class='chiMuc'>Khoi chieu</p>"
                                            + "<p class='noiDung'>"+i.KhoiChieu+"</p>"
                                         + "</div>"
                                        +"<div>"
                                            +"<p class='chiMuc'>Thoi luong</p>"
                                            + "<p class='noiDung'>"+i.ThoiLuong+"</p>"
                                         + "</div>"
                                        +"<div>"
                                            +"<p class='chiMuc'>Ngon ngu</p>"
                                            + "<p class='noiDung'>"+i.NgonNgu+"</p>"
                                         + "</div>"
                                    +"</div>"
                                    + "<a href='/ChonTP.aspx?IDPhim=" + i.Id + "&TenPhim=" + i.Ten + "' class='btnMuaVe'>"
                                        + "<div>Mua ve</div>"
                                    +"</a>"
                                +"</div>"
                            +"</div>"
                        +"</div>"

                        +"<div class='moTa'>"
                            +"<h3>Noi dung phim</h3>"
                            + "<p>"+i.NoiDung+"</p>"
                         + "</div>";
                }
            }

            thonTinPhim.InnerHtml = trP;

            // lay danh sach phim khac
            int dm = 0;

            string tgP2 = "";
            foreach(phim i in f)
            {
                if(i.Id != idPhim)
                {
                    dm++;
                    tgP2 += "<div class='ctPhim'>"
                            + "<a href='/TrangChiTiet.aspx?idPhim=" + i.Id + "' class='trailer'>"
                                + "<img src='" + i.Anh + "' alt='error' class='imagePhim'>"
                            + "</a>"
                            + "<div class='contentPhim'>"
                                + "<h3 class='namePhim'>" + i.Ten + "</h3>"
                                + "<a href='/TrangChiTiet.aspx?idPhim=" + i.Id + "' class='btn btnChiTiet'>"
                                    + "<div>Xem chi tiet</div>"
                                + "</a>"
                                + "<a href='/ChonTP.aspx?IDPhim=" + i.Id + "&TenPhim=" + i.Ten + "' class='btn btnMua'>"
                                    + "<div>Mua ve</div>"
                                + "</a>"
                            + "</div>"
                        + "</div>";
                }

                if (dm == 5) break;
            }
            moveSelection.InnerHtml = tgP2;
        }
    }
}