using System;

namespace classIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = " engin demiroğ";
            kurs1.IzlenmeOrani = 68;

            //ctrl k d

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "java";
            kurs2.Egitmen = " ali";
            kurs2.IzlenmeOrani = 28;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "C";
            kurs3.Egitmen = " berk";
            kurs3.IzlenmeOrani = 43;
            // Console.WriteLine(kurs1.KursAdi + " :" + kurs1.Egitmen + " " + kurs1.IzlenmeOrani);

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " :" + kurs.Egitmen);


            }
        }
    }

    class Kurs
    {
        //property özellik

        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
