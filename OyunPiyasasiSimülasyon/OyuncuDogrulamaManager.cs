using System;
using System.Collections.Generic;
using System.Text;

namespace OyunPiyasasiSimülasyon
{
    class OyuncuDogrulamaManager : IOyuncuDogrulama
    {
        public bool dogrulama(Oyuncu oyuncu)
        {
            if (oyuncu.Ad == "Mustafa" && oyuncu.Soyad == "EKİCİ" && oyuncu.TcNo == "123321")
            {
                Console.WriteLine("Kullanıcı Doğru Girildi.");
                return true;
            }
            else { Console.WriteLine("Kullanıcı Bulunamadı.Tekrar Deneyiniz."); return false; }       
        }
    }
}
