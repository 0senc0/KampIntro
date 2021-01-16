using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {  
            //alias değer tutucu

            string kategoriEtiketi = "kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;

            bool sistemeGirisYapmisMi = true;

            //tab tab

            if (sistemeGirisYapmisMi==true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }

            Console.WriteLine(kategoriEtiketi);
        }
    }
}
