using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdisyonTakip
{
    public class Veriler
    {
        public Veriler()
        {
            Urunler = new List<Urun>()
                          {
                              new Urun() { Adi = "Çay", AltGrup = "Sıcak İçecek", Grup = "İçeçekler 1", Fiyat = 4 },
                              new Urun() { Adi = "Kahve", AltGrup = "Kahveler", Grup = "İçeçekler 1", Fiyat = 5.4}
                          };
            Fisler = new List<Fis>();
            Adisyonlar = new List<Adisyon>();
        }

        public List<Urun> Urunler
        {
            get;
            set;
        }

        public List<Adisyon> Adisyonlar
        {
            get;
            set;
        }

        public List<Fis> Fisler
        {
            get;
            set;
        }
    }
}