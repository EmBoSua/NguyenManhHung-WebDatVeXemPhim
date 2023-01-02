using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace v2
{
    public partial class ChonTP : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //kiem tra xem da dang nhap chua va hien ten dang nhap
            if ((string)Session["tenUser"] != null)
            {
                tenUser.InnerText = (string)Session["tenUser"];
                out_div.Attributes.Remove("class");

                // lay id cua phim da chon
                string idPC = Request.QueryString.Get("IDPhim");

                // luu idPC len tren session
                vecuatoi vct = new vecuatoi();
                vct.IdPhim = idPC;

                List<phim> p = (List<phim>)Application["listPhim"];
                foreach(phim i in p)
                {
                    if(i.Id == idPC)
                    {
                        vct.TenPhim = i.Ten;
                        vct.AnhPhim = i.Anh;
                    }
                }

                Session["VCT"] = vct;

                // lay ra ta ca phim cua cac rap
                List<phimcuarap> fcr = (List<phimcuarap>)Application["phimCuaRap"];

                // lay ra nhung rap co phim do
                List<phimcuarap> fcrTG = new List<phimcuarap>();
                foreach(phimcuarap i in fcr)
                {
                    if(i.IdPhim == idPC)
                    {
                        fcrTG.Add(i);
                    }
                }

                Session["fcrTG"] = fcrTG;

                // lay ra thong tin toan bo cac rap
                List<rap> r = (List<rap>)Application["rap"];

                List<rap> rTG = new List<rap>();
                foreach(phimcuarap i in fcrTG)
                {
                    foreach(rap j in r)
                    {
                        if(i.IdRap == j.IdRap)
                        {
                            rTG.Add(j);
                        }
                    }
                }

                Session["rTG"] = rTG;

                // lay ra thanh pho rap do dang o
                List<thanhpho> tp = (List<thanhpho>)Application["thanhPho"];

                List<thanhpho> tpTG = new List<thanhpho>();
                foreach(rap i in rTG)
                {
                    foreach(thanhpho j in tp)
                    {
                        if(i.IdTP == j.Id)
                        {
                            bool chuaCo = true;
                            foreach (thanhpho x in tpTG)
                            {
                                if (j.Id == x.Id)
                                {
                                    chuaCo = false;
                                }
                            }
                            if (chuaCo)
                            {
                                tpTG.Add(j);
                            }
                        }
                    }
                }

                Session["tpTG"] = tpTG;

                // dua du leu len web
                string anh = "<img src='"+vct.AnhPhim+"' alt='Ảnh Phim'>";
                divAnhPhim.InnerHtml = anh;

                string btn = "";
                foreach(thanhpho i in tpTG)
                {
                    btn += "<a href='/ChonRap.aspx?IDThanhPho="+i.Id+"&TenThanhPho="+i.Ten+"' class='btnCTP'><div>"+i.Ten+"</div></a>";
                }

                allBTN.InnerHtml = btn;

            }
            else
            {
                string thongBao = "<script>alert('Bạn cần đăng nhập trước');</script>";
                //Response.Write(thongBao);
                Response.Redirect("DangNhap.aspx");
            }
        }
    }
}