using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdisyonTakip
{
    public class Urun
    {
        public Urun(string adi, string altGrup, string grup, double fiyat)
        {
            Adi = adi;
            AltGrup = altGrup;
            Grup = grup;
            Fiyat = fiyat;
        }

        public Urun()
        {

        }

        public string Adi
        {
            get;
            set;
        }

        internal void Deneme(string v1, int v2)
        {

        }

        public string Grup
        {
            get;
            set;
        }

        public string AltGrup
        {
            get;
            set;
        }

        public double Fiyat
        {
            get;
            set;
        }

        public void GrupTasi(string yeniGrupAdi)
        {
            Grup = yeniGrupAdi;
        }
    }
}