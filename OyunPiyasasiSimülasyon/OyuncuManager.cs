using System;
using System.Collections.Generic;
using System.Text;

namespace OyunPiyasasiSimülasyon
{
    class OyuncuManager : IOyuncuService
    {
        private OyuncuDogrulamaManager oyuncuDogrulamaManager;

        public OyuncuManager(OyuncuDogrulamaManager oyuncuDogrulamaManager)
        {
            this.oyuncuDogrulamaManager = oyuncuDogrulamaManager;
        }

        public void Ekle(Oyuncu oyuncu)
        {
            Console.WriteLine(oyuncu.Ad+" "+oyuncu.Soyad+" İsimli kullanıcı eklendi");
        }

        public void Guncelle(Oyuncu oyuncu)
        {
            Console.WriteLine(oyuncu.Ad + " " + oyuncu.Soyad + " İsimli kullanıcı güncellendi");
        }

        public void Sil(Oyuncu oyuncu)
        {
            Console.WriteLine(oyuncu.Ad + " " + oyuncu.Soyad + " İsimli kullanıcı silindi");
        }
    }
}
