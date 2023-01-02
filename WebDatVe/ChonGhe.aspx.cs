using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace v2
{
    public partial class ChonGhe : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //kiem tra xem da dang nhap chua va hien ten dang nhap
            if ((string)Session["tenUser"] != null)
            {
                tenUser.InnerText = (string)Session["tenUser"];
                out_div.Attributes.Remove("class");
            }

            // lay lich chieu da chon
            string lcC = Request.QueryString.Get("LichChieu");

            // luu lich chieu len session
            vecuatoi vct = (vecuatoi)Session["VCT"];
            vct.LichChieu = lcC;

            Session["VCT"] = vct;

            // lay danh sach lich chieu cua phim o rap da chon (o day co so ghe)
            List<lichchieucuaphim> lccf = (List<lichchieucuaphim>)Session["lccfTG"];

            // lay so ghe con
            string soGhe = "";
            foreach(lichchieucuaphim i in lccf)
            {
                if(i.LichChieu == lcC)
                {
                    soGhe = i.SoGhe;
                }
            }

            // dua du leu len web
            string anh = "<img src='" + vct.AnhPhim + "' alt='Ảnh Phim'>";
            divAnhPhim.InnerHtml = anh;

            string[] ghe = soGhe.Split(',');
            Session["dsGhe"] = ghe;

            string btn = "";
            foreach (string i in ghe)
            {
                btn += "<a href='/VeCuaToi.aspx?Ghe=" + i + "' class='btnCTP'><div>" + i + "</div></a>";
            }

            allBTN.InnerHtml = btn;
        }
    }
}