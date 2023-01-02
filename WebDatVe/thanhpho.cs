using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace v2
{
    public class thanhpho
    {

        private string id;
        private string ten;

        public thanhpho()
        {
        }

        public thanhpho(string id, string ten)
        {
            this.id = id;
            this.ten = ten;
        }

        public string Id { get => id; set => id = value; }
        public string Ten { get => ten; set => ten = value; }
    }
}