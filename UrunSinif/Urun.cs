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
        public string marka;
        public string altKategori;
        public bool secildi;

        public override string ToString()
        {
            return marka + " - " + altKategori;
        }

        
    }
}

