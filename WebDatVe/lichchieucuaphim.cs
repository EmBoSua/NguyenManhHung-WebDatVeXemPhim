using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace v2
{
    public class lichchieucuaphim
    {
        private string idRap;
        private string idPhim;
        private string lichChieu;
        private string soGhe;

        public lichchieucuaphim()
        {
        }

        public lichchieucuaphim(string idRap, string idPhim, string lichChieu, string soGhe)
        {
            this.idRap = idRap;
            this.idPhim = idPhim;
            this.lichChieu = lichChieu;
            this.soGhe = soGhe;
        }

        public string IdRap { get => idRap; set => idRap = value; }
        public string IdPhim { get => idPhim; set => idPhim = value; }
        public string LichChieu { get => lichChieu; set => lichChieu = value; }
        public string SoGhe { get => soGhe; set => soGhe = value; }
    }
}