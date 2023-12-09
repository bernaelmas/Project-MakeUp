using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrunSinif
{
    public class GozUrun : Urun
    {
        private string renk;

        public GozUrun(string marka, string altKategori, string renk)
        {
            this.marka = marka;
            this.altKategori = altKategori;
            this.renk = renk;

        }
    }
}
