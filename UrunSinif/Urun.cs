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
        protected string marka;
        protected string altKategori;
        protected bool secildi;

        public override string ToString()
        {
            return marka + " - " + altKategori;
        }
    }
}
