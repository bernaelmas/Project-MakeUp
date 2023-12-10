﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrunSinif
{
    public class DudakUrun : Urun
    {
        /*
         public string marka { get; set; }
         public string altKategori { get; set; }
         public decimal fiyat { get; set; }
        */
        public string renk { get; set; }
        public DudakUrun(string marka, string altKategori, string renk, decimal fiyat)
        {
            this.marka = marka;
            this.altKategori = altKategori;
            this.renk = renk;
            this.fiyat = fiyat;
        }
        public override string ToString()
        {
            return base.ToString() + marka + " - " + altKategori + " - " + renk + " = " + fiyat.ToString("N");
        }
    }
}
