using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace v2
{
    public class rap
    {

        private string idRap;
        private string tenRap;
        private string diaChiRap;
        private string idTP;

        public rap()
        {
        }

        public rap(string idRap, string tenRap, string diaChiRap, string idTP)
        {
            this.idRap = idRap;
            this.tenRap = tenRap;
            this.diaChiRap = diaChiRap;
            this.idTP = idTP;
        }

        public string IdRap { get => idRap; set => idRap = value; }
        public string TenRap { get => tenRap; set => tenRap = value; }
        public string DiaChiRap { get => diaChiRap; set => diaChiRap = value; }
        public string IdTP { get => idTP; set => idTP = value; }
    }
}