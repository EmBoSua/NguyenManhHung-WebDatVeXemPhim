using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace v2
{
    public class phim
    {
        private string id;
        private string anh;
        private string ten;
        private string daoDien;
        private string dienVien;
        private string theLoai;
        private string khoiChieu;
        private string thoiLuong;
        private string ngonNgu;
        private string noiDung;
        private string giaVe;

        public phim()
        {
        }

        public phim(
            string id,
            string anh,
            string ten,
            string daoDien,
            string dienVien,
            string theLoai,
            string khoiChieu,
            string thoiLuong,
            string ngonNgu,
            string noiDung,
            string giaVe)
        {
            this.id = id;
            this.anh = anh;
            this.ten = ten;
            this.daoDien = daoDien;
            this.dienVien = dienVien;
            this.theLoai = theLoai;
            this.khoiChieu = khoiChieu;
            this.thoiLuong = thoiLuong;
            this.ngonNgu = ngonNgu;
            this.noiDung = noiDung;
            this.giaVe = giaVe;
        }

        public string Id { get => id; set => id = value; }
        public string Anh { get => anh; set => anh = value; }
        public string Ten { get => ten; set => ten = value; }
        public string DaoDien { get => daoDien; set => daoDien = value; }
        public string DienVien { get => dienVien; set => dienVien = value; }
        public string TheLoai { get => theLoai; set => theLoai = value; }
        public string KhoiChieu { get => khoiChieu; set => khoiChieu = value; }
        public string ThoiLuong { get => thoiLuong; set => thoiLuong = value; }
        public string NgonNgu { get => ngonNgu; set => ngonNgu = value; }
        public string NoiDung { get => noiDung; set => noiDung = value; }
        public string GiaVe { get => giaVe; set => giaVe = value; }
    }
}
