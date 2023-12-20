using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrunSinif
{
    public interface IUrun
    {
        public string marka { get; set; }
        public string altKategori { get; set; }
        public bool secildi { get; set; }
        public decimal fiyat { get; set; }
 
    }
}
