﻿using System;
using System.Collections.Generic;
using System.Text;

namespace metotlar
{
    class SepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sepete Eklendi : " + urun.Adi);
        }

        public void Ekle2(string urunAdi, string aciklama ,double fiyat, int stokAdedi) {
            Console.WriteLine("Sepete Eklendi : " + urunAdi);
        
        }
    }
}
