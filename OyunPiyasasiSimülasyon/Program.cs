using System;

namespace OyunPiyasasiSimülasyon
{
    class Program
    {
        static void Main(string[] args)
        {
            Oyuncu oyuncu1 = new Oyuncu();
            oyuncu1.Ad = "Mustafa";
            oyuncu1.Soyad = "EKİCİ";
            oyuncu1.TcNo = "123321";
            oyuncu1.DogumTarihi = "1998";

            Oyuncu oyuncu2 = new Oyuncu();
            oyuncu2.Ad = "Ayşe";
            oyuncu2.Soyad = "ÇELİK";
            oyuncu2.TcNo = "1234";
            oyuncu2.DogumTarihi = "1998";

            Oyuncu oyuncu3 = new Oyuncu();
            oyuncu3.Ad = "Muhammed";
            oyuncu3.Soyad = "DEMİR";
            oyuncu3.TcNo = "12345";
            oyuncu3.DogumTarihi = "1995";

            KampanyaManager kampanyaManager = new KampanyaManager();
            kampanyaManager.KampanyaEkle(new Kampanya());

            OyuncuDogrulamaManager oyuncuDogrulamaManager = new OyuncuDogrulamaManager();
            OyuncuManager oyuncuManager = new OyuncuManager(oyuncuDogrulamaManager);
            oyuncuDogrulamaManager.dogrulama(oyuncu1);
            oyuncuDogrulamaManager.dogrulama(oyuncu2);
            oyuncuManager.Ekle(oyuncu1);
            oyuncuManager.Guncelle(oyuncu2);
            oyuncuManager.Sil(oyuncu3);
        }
    }
}
