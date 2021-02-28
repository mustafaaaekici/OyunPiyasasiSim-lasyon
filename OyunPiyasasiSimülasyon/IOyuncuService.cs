using System;
using System.Collections.Generic;
using System.Text;

namespace OyunPiyasasiSimülasyon
{
    interface IOyuncuService
    {
        void Ekle(Oyuncu oyuncu);
        void Sil(Oyuncu oyuncu);
        void Guncelle(Oyuncu oyuncu);
    }
}
