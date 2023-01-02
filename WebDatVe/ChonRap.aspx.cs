using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace v2
{
    public partial class ChonRap : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //kiem tra xem da dang nhap chua va hien ten dang nhap
            if ((string)Session["tenUser"] != null)
            {
                tenUser.InnerText = (string)Session["tenUser"];
                out_div.Attributes.Remove("class");
            }

            // xoa session da dung
            //Session.Remove("tpTG");

            // lay id thanh pho da chon
            string idTPC = Request.QueryString.Get("IDThanhPho");
            string tenTP = Request.QueryString.Get("TenThanhPho");

            // luu idTPC len session
            Session["idTPC"] = idTPC;// chua dung
            Session["tenTP"] = tenTP;// chua dung

            // lay ra cac rap co chia phi da chon
            List<rap> r = (List<rap>)Session["rTG"];

            // lay ra cac rap o thanh pho nay
            List<rap> rTP = new List<rap>();
            foreach(rap i in r)
            {
                if(i.IdTP == idTPC)
                {
                    rTP.Add(i);
                }
            }

            // dua du leu len web
            vecuatoi vct = (vecuatoi)Session["VCT"];
            string anh = "<img src='" + vct.AnhPhim + "' alt='Ảnh Phim'>";
            divAnhPhim.InnerHtml = anh;

            string btn = "";
            foreach (rap i in rTP)
            {
                btn += "<a href='/ChonNgay.aspx?IDRap=" + i.IdRap + "&TenRap="+i.TenRap+"' class='btnCTP'><div>" + i.TenRap + "</div></a>";
            }

            allBTN.InnerHtml = btn;
        }
    }
}