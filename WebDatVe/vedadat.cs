using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace v2
{
    public class vedadat
    {

        private string idEmail;
        private string idPhim;
        private string tenPhim;
        private string lichPhim;
        private string soGhe;
        private string idRap;
        private string tenRap;
        private string ngayDat;

        public vedadat()
        {
        }

        public vedadat(string idEmail, string idPhim, string tenPhim, string lichPhim, string soGhe, string idRap, string tenRap, string ngayDat)
        {
            this.idEmail = idEmail;
            this.idPhim = idPhim;
            this.tenPhim = tenPhim;
            this.lichPhim = lichPhim;
            this.soGhe = soGhe;
            this.idRap = idRap;
            this.tenRap = tenRap;
            this.ngayDat = ngayDat;
        }

        public string IdEmail { get => idEmail; set => idEmail = value; }
        public string IdPhim { get => idPhim; set => idPhim = value; }
        public string TenPhim { get => tenPhim; set => tenPhim = value; }
        public string LichPhim { get => lichPhim; set => lichPhim = value; }
        public string SoGhe { get => soGhe; set => soGhe = value; }
        public string IdRap { get => idRap; set => idRap = value; }
        public string TenRap { get => tenRap; set => tenRap = value; }
        public string NgayDat { get => ngayDat; set => ngayDat = value; }
    }
}