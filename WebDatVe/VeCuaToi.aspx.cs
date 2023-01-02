using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace v2
{
    public partial class VeCuaToi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //kiem tra xem da dang nhap chua va hien ten dang nhap
            if ((string)Session["tenUser"] != null)
            {
                tenUser.InnerText = (string)Session["tenUser"];
                out_div.Attributes.Remove("class");
            }

            // lay so ghe da chon
            string ghe = Request.QueryString.Get("Ghe");

            // lay lich xem
/*            string lich = (string)Session["lcC"];

            // lay ten rap
            string tenRap = (string)Session["TenRap"];

            // lay dia chi rap
            string diaChi = (string)Session["tenTP"];

            // lay ten phim
            string idPhim = (string)Session["idPC"];
            string tenPhim = (string)Session["TenPhim"];*/


            // lay danh sach ve phim da dat
            List<vecuatoi> dsVCT = (List<vecuatoi>)Application["dsVeCuaToi"];

            // lay email nguoi dung
            string email = (string)Session["emailUser"];

            vecuatoi vct = (vecuatoi)Session["VCT"];
            vct.EmailND = email;
            vct.SoGhe = ghe;
            vct.NgayMua = DateTime.Now.ToString("dd/MM/yyyy");

            if(ghe != null)
            {
                dsVCT.Add(vct);
                Application["dsVeCuaToi"] = dsVCT;
            }

            // hien ve
            string tb = "<div class='vctTieuDe'>"
                            +"<h2>DANH SÁCH VÉ CỦA TÔI</h2>"
                            +"<hr>"
                        +"</div>";
            tb += "<table>"
                            + "<tr>"
                                + "<th>" + "STT" + "</th>"
                                + "<th>" + "Ảnh" + "</th>"
                                + "<th>" + "Tên Phim" + "</th>"
                                + "<th>" + "Lịch Chiếu" + "</th>"
                                + "<th>" + "Số ghế" + "</th>"
                                + "<th>" + "Tên Rạp" + "</th>"
                                + "<th>" + "Ngày Mua" + "</th>"
                                + "<th>" + "Giá Vé" + "</th>"
                            + "</tr>";

            List<phim> phim = (List<phim>)Application["listPhim"];

            int tong = 0;
            int giave = 0;
            for (int i=0; i<dsVCT.Count; i++)
            {
                if(dsVCT[i].EmailND == email)
                {
                    tb += "<tr>"
                                + "<td>" + i + "</td>"
                                + "<td class='vctCotAnh'>"
                                    + "<div class='vctAnhPhim'><img class='vctAnhChinh' src='" + dsVCT[i].AnhPhim + "' alt='anh phim'></div>"
                                    + "<img class='vctAnhhover' src='" + dsVCT[i].AnhPhim + "' alt='anh phim'>"
                                + "</td>"
                                + "<td>" + dsVCT[i].TenPhim + "</td>"
                                + "<td>" + dsVCT[i].LichChieu + "</td>"
                                + "<td>" + dsVCT[i].SoGhe + "</td>"
                                + "<td>" + dsVCT[i].TenRap + "</td>"
                                + "<td>" + dsVCT[i].NgayMua + "</td>";
                                foreach(phim j in phim)
                    {
                        if(j.Id == dsVCT[i].IdPhim)
                        {
                            giave = Int32.Parse(j.GiaVe) ;
                            tong += giave;
                        }
                    }
                                tb += "<td>" + giave+ " VND</td>"
                          + "</tr>";
                }
            }

            tb += "</table>";
            
            TongTien.InnerHtml = "<h3>Tổng Tiền: "+tong+" VND</h3>";

            vctKhung.InnerHtml = tb;

            // cap nhat so ghe cho danh sach
            if(ghe != null)
            {
                string[] dsGhe = (string[])Session["dsGhe"];
            
                string tg = "";
                int n = dsGhe.Length;
                for(int i=0; i<n; i++)
                {
                    if(dsGhe[i] != ghe)
                    {
                        if (i < (n - 1))
                        {
                            tg += dsGhe[i] + ",";
                        }
                        else
                        {
                            tg += dsGhe[i];
                        }
                    }
                
                }

    /*            string idRC = (string)Session["idRC"];
                string idPC = (string)Session["idPC"];*/
                List<lichchieucuaphim> lccf = (List<lichchieucuaphim>)Application["lichChieuCuaPhim"];

                List<lichchieucuaphim> lcTG = new List<lichchieucuaphim>();
                bool ok = false;
                foreach (lichchieucuaphim i in lccf)
                {
                    if (i.IdRap == vct.IdRap && i.IdPhim == vct.IdPhim && i.LichChieu == vct.LichChieu)
                    {
                        i.SoGhe = tg;
                        ok = true;
                    }
                    lcTG.Add(i);
                }

                Application["lichChieuCuaPhim"] = lcTG;      
            }
                  
        }
    }
}