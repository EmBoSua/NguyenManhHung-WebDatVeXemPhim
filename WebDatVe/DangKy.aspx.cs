using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace v2
{
    public partial class DangKy : System.Web.UI.Page
    {
        List<nguoidung> dsND;
        protected void Page_Load(object sender, EventArgs e)
        {
            //kiem tra xem da dang nhap chua va hien ten dang nhap
            if ((string)Session["tenUser"] != null)
            {
                tenUser.InnerText = (string)Session["tenUser"];
                out_div.Attributes.Remove("class");
            }

            dsND = (List<nguoidung>)Application["dsNguoiDung"];

            
        }

        protected void btnDangKy_Click(object sender, EventArgs e)
        {
            string ten = Request.Form["Ten"];
            string email = Request.Form["Email"];
            string sdt = Request.Form["SDT"];
            string pass = Request.Form["Pass"];

            bool ok = true;

            for (int i = 0; i < dsND.Count; i++)
            {
                if (dsND[i].Email == email)
                {
                    ok = false;
                    error_email.InnerHtml = "* Email đã tồn tại.";
                    break;
                }
                else
                {
                    error_email.InnerHtml = "";
                }
                if (dsND[i].Sdt == sdt)
                {
                    ok = false;
                    error_sdt.InnerHtml = "* Số điện thoại đã tồn tại.";
                    break;
                }
                else
                {
                    error_sdt.InnerHtml = "";
                }
            }

            if (ok)
            {
                nguoidung us = new nguoidung() { Email = email, Sdt = sdt, Ten = ten, MatKhau = pass };
                dsND.Add(us);
                Application["dsNguoiDung"] = dsND;
                Response.Redirect("/DangNhap.aspx");
            }
        }
    }
}