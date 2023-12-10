using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace UrunSinif
{
    public abstract class Urun
    {
        public string marka {  get; set; }
        public string altKategori { get; set; }
        public bool secildi { get; set; }
        public decimal fiyat { get; set; }

        public override string ToString()
        {
            return " - ";
        }
    }
}

