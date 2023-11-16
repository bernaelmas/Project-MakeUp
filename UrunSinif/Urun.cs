using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace UrunSinif
{
    public class Urun
    {
        private string marka;
        private string kategori;
        private string altKategori;
        private bool secildi;
        private string urunRengi;

        public Urun (string marka, string kategori, string altKategori, string urunRengi)
        {
            this.marka = marka;
            this.kategori = kategori;
            this.altKategori = altKategori;
            this.urunRengi = urunRengi;
            this.secildi = false;
        }
        public override string ToString(){
            return $"{marka} - {urunRengi} {altKategori}";}
        public string GetMarka(){
            return marka;}
        public void SetMarka(string marka){
            this.marka = marka;}
        public string GetKategori(){
            return kategori;}
        public void SetKategori(string kategori){
            this.kategori = kategori;}
        public string GetAltKategori(){
            return altKategori;}
        public void SetAltKategori(string altkategori){
            this.altKategori = altkategori;}
        public bool GetSecildi(){
            return secildi; }
        public void SetSecildi(bool secildi){
            this.secildi = secildi; }
        public string GetUrunRengi(){
            return urunRengi;}
        public void SetUrunRengi(string urunRengi){
            this.urunRengi = urunRengi;}
    }
}
