using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace UrunSinif
{
    public class TenUrun : Urun
    {
        private string renk;
       
        public TenUrun(string marka, string altKategori, string renk)
        {
            this.marka = marka;
            this.altKategori = altKategori;
            this.renk = renk;
        }
    }
}
