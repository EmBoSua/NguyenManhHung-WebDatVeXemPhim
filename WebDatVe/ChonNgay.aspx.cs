using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace v2
{
    public partial class ChonNgay : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //kiem tra xem da dang nhap chua va hien ten dang nhap
            if ((string)Session["tenUser"] != null)
            {
                tenUser.InnerText = (string)Session["tenUser"];
                out_div.Attributes.Remove("class");
            }

            // lay id rap da chon
            string idRC = Request.QueryString.Get("IDRap");
            string tenRap = Request.QueryString.Get("TenRap");

            // luu id rap da chon len session
            vecuatoi vct = (vecuatoi)Session["VCT"];
            vct.IdRap = idRC;
            vct.TenRap = tenRap;

            Session["VCT"] = vct;

            // lay id cua phim da chon
            string idPC = vct.IdPhim;

            // lay tat ca lich chieu
            List<lichchieucuaphim> lccf = (List<lichchieucuaphim>)Application["lichChieuCuaPhim"];

            // lay lich chieu cua phim o rap da chon
            List<lichchieucuaphim> lccfTG = new List<lichchieucuaphim>();
            foreach(lichchieucuaphim i in lccf)
            {
                if(i.IdRap == idRC && i.IdPhim == idPC)
                {
                    lccfTG.Add(i);
                }
            }

            Session["lccfTG"] = lccfTG;

            // dua du leu len web
            string anh = "<img src='" + vct.AnhPhim + "' alt='Ảnh Phim'>";
            divAnhPhim.InnerHtml = anh;

            string btn = "";
            foreach (lichchieucuaphim i in lccfTG)
            {
                btn += "<a href='/ChonGhe.aspx?LichChieu=" + i.LichChieu + "' class='btnCTP'><div>" + i.LichChieu + "</div></a>";
            }

            allBTN.InnerHtml = btn;
        }
    }
}