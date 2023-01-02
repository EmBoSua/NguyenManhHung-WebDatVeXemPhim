using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace v2
{
    public partial class DangNhap : System.Web.UI.Page
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

        protected void btnDN_Click(object sender, EventArgs e)
        {
            string email = Request.Form["Email"];
            string pass = Request.Form["Pass"];
            string ten = "";
            string sdt = "";
            bool ok = false;

            if (IsPostBack)
            {
                if (dsND.Count == 0)
                {
                    error_pass.InnerHtml = "* Tài khoản không tồn tại.";
                }
                else
                {
                    foreach (nguoidung i in dsND)
                    {
                        if (i.Email == email && i.MatKhau == pass)
                        {
                            ok = true;
                            ten = i.Ten;
                            sdt = i.Sdt;
                        }
                    }
                }

                if (ok)
                {
                    Session["emailUser"] = email;
                    Session["sdtUser"] = sdt;
                    Session["tenUser"] = ten;
                    Response.Redirect("/index.aspx");
                    Response.End();
                }
                else
                {
                    error_pass.InnerHtml = "* Email hoặc mật khẩu không khớp";
                }
            }
        }
    }
}