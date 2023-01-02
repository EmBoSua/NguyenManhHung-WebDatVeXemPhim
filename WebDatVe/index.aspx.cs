using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace v2
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            //kiem tra xem da dang nhap chua va hien ten dang nhap
            if ((string)Session["tenUser"] != null)
            {
                tenUser.InnerText = (string)Session["tenUser"];
                out_div.Attributes.Remove("class");
            }

            // lay danh sach phim
            List<phim> f = (List<phim>)Application["listPhim"];

            int dem = 0;
            string tr = "";
            foreach(phim i in f)
            {
                tr += "<div class='Phim'>"
                        + "<a href='/TrangChiTiet.aspx?idPhim=" + i.Id + "' class='trailer'>"
                            + "<img src='"+i.Anh+"' alt='error' class='imagePhim'>"
                        + "</a>"
                        + "<div class='contentPhim'>"
                            + "<h3 class='namePhim'>"+i.Ten+"</h3>"
                            + "<a href='/TrangChiTiet.aspx?idPhim="+i.Id+"' class='btn btnChiTiet'>"
                                + "<div>Xem chi tiet</div>"
                            + "</a>"
                            + "<a href='/ChonTP.aspx?IDPhim="+i.Id+"&TenPhim="+i.Ten+"' class='btn btnMua'>"
                                + "<div>Mua ve</div>"
                            + "</a>"
                        + "</div>"
                    + "</div>";
                dem++;
                if (dem == 10) break;
            }

            moveSelection.InnerHtml = tr;
        }
    }
}