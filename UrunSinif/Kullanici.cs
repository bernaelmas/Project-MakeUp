using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrunSinif
{
    public class Kullanici
    {
        public string AdSoyad {  get; set; }
        public string Sifre { get; set; }
        public double Bakiye {  get; set; }

        public Kullanici(string AdSoyad, string Sifre) 
        {
            this.AdSoyad = AdSoyad;
            this.Sifre = Sifre;
            this.Bakiye = 0;
        }
    }
}
