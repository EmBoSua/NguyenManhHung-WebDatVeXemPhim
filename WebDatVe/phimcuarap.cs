using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace v2
{
    public class phimcuarap
    {
        private string idRap;
        private string idPhim;

        public phimcuarap()
        {
        }

        public phimcuarap(string idRap, string idPhim)
        {
            this.idRap = idRap;
            this.idPhim = idPhim;
        }

        public string IdRap { get => idRap; set => idRap = value; }
        public string IdPhim { get => idPhim; set => idPhim = value; }

    }
}