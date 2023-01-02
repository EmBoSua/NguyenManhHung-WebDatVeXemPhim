using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace v2
{
    public class nguoidung
    {
        private string ten;
        private string sdt;
        private string email;
        private string matKhau;

        public nguoidung()
        {
        }

        public nguoidung(string ten, string sdt, string email, string matKhau)
        {
            this.ten = ten;
            this.sdt = sdt;
            this.email = email;
            this.matKhau = matKhau;
        }

        public string Ten { get => ten; set => ten = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Email { get => email; set => email = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
    }
}