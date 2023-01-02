using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace v2
{
    public class vecuatoi
    {
        private string emailND;
        private string idPhim;
        private string anhPhim;
        private string tenPhim;
        private string lichChieu;
        private string soGhe;
        private string idRap;
        private string tenRap;
        private string ngayMua;

        public vecuatoi()
        {
        }

        public vecuatoi(string emailND, string idPhim, string anhPhim, string tenPhim, string lichChieu, string soGhe, string idRap, string tenRap, string ngayMua)
        {
            this.emailND = emailND;
            this.idPhim = idPhim;
            this.anhPhim = anhPhim;
            this.tenPhim = tenPhim;
            this.lichChieu = lichChieu;
            this.soGhe = soGhe;
            this.idRap = idRap;
            this.tenRap = tenRap;
            this.ngayMua = ngayMua;
        }

        public string EmailND { get => emailND; set => emailND = value; }
        public string IdPhim { get => idPhim; set => idPhim = value; }
        public string AnhPhim { get => anhPhim; set => anhPhim = value; }
        public string LichChieu { get => lichChieu; set => lichChieu = value; }
        public string SoGhe { get => soGhe; set => soGhe = value; }
        public string IdRap { get => idRap; set => idRap = value; }
        public string TenRap { get => tenRap; set => tenRap = value; }
        public string NgayMua { get => ngayMua; set => ngayMua = value; }
        public string TenPhim { get => tenPhim; set => tenPhim = value; }


    }
}