using System;
using System.Collections.Generic;
using System.Text;

namespace OyunPiyasasiSimülasyon
{
    class KampanyaManager:IKampanyaManager
    {
        public void KampanyaEkle(Kampanya kampanya)
        {
            Console.WriteLine("Kampanya Eklendi");
        }

        public void KampanyaGuncelle(Kampanya kampanya)
        {
            Console.WriteLine("Kampanya Silindi");
        }

        public void KampanyaSil(Kampanya kampanya)
        {
            Console.WriteLine("Kampanya Güncellendi");
        }
    }
}
