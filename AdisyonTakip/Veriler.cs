namespace AdisyonTakip
{
    using System.Collections.Generic;

    public class Veriler
    {
        public Veriler()
        {
            Urunler = new List<Urun>();
            Urun kahve = new Urun { Adi = "Kahve", AltGrup = "Kahveler", Grup = "İçeçekler 1", Fiyat = 5.4 };
            kahve = new Urun("Kahve", "Kahveler", "İçeçekler 1", 5);
            kahve.GrupTasi("Yeni Kahveler");
            kahve.Deneme("ahmet", 4);
            Urunler.Add(kahve);
            Urunler.Add(new Urun { Adi = "Çay", AltGrup = "Sıcak İçecek", Grup = "İçeçekler 1", Fiyat = 4 });
            Kalem kahveAdisyon = new Kalem { Miktar = 1, Urun = kahve };
            Adisyonlar = new List<Kalem> { kahveAdisyon };
            Fisler = new List<Adisyon> { new Adisyon { Adisyonlar = new List<Kalem> { kahveAdisyon }, MasaAdi = "Masa1" } };
        }

        public List<Kalem> Adisyonlar { get; set; }

        public List<Adisyon> Fisler { get; set; }

        public List<Urun> Urunler { get; set; }
    }
}