using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdisyonTakip
{
    public class Adisyon
    {
        public string MasaAdi
        {
            get;
            set;
        }

        public List<Kalem> Adisyonlar
        {
            get;
            set;
        }

        public OdemeTipleri OdemeTipi
        {
            get;
            set;
        }

        public double ToplamFiyat
        {
            get;
            set;
        }

        public double OdemeMiktari
        {
            get;
            set;
        }

        public DateTime KapamaZamani
        {
            get;
            set;
        }
    }
}