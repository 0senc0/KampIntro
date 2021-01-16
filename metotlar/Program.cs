﻿using System;

namespace metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elmasi";

            Urun urun2 = new Urun();
            urun2.Adi = "karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "diyarbakir karpuzu";

            Urun[] urunler = new Urun[] {urun1, urun2};


            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("+++++++++++++++++++++");
            }

            //instance örnek
            //cw tab
            //encapsulation
            //bir değişiklik yapınca fonksiyonda patlıyor değiştirmek gerekiyor o yuzden class kullanılmalı
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("armut", "yeşil", 12,10);
            sepetManager.Ekle2("y", "y", 12,9);
            sepetManager.Ekle2("x", "x", 12,8);
        }
    }
}
//dont repeat yourself