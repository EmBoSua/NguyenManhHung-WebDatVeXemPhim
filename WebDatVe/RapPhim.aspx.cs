using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace v2
{
    public partial class RapPhim : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //kiem tra xem da dang nhap chua va hien ten dang nhap
            if ((string)Session["tenUser"] != null)
            {
                tenUser.InnerText = (string)Session["tenUser"];
                out_div.Attributes.Remove("class");
            }

            // lay danh sach thanh pho
            List<thanhpho> dsTP = (List<thanhpho>)Application["thanhPho"];

            //  lay danh sach rap
            List<rap> dsR = (List<rap>)Application["rap"];

            string ds = "";

            foreach(thanhpho i in dsTP)
            {
                ds += "<div class='rMotDong'>"
                        + "<h2 class='rChiMuc'>" + i.Ten + "</h2>"
                        + "<div class='rDiaDiemAll'>";
                foreach(rap j in dsR)
                {
                    if(j.IdTP == i.Id)
                    {
                        ds += "<div class='rDiaDiem'>"+j.TenRap+"</div>";
                    }
                }

                ds += "</div>"+"</div>";
            }

            rKhungNgoai.InnerHtml = ds;
        }
    }
}