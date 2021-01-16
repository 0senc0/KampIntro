using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            //array diziler

            string[] kurslar = new string[] { "yazılım geliştirici yetiştirme kampı", " java", "css" };


            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

                foreach (string kurs in kurslar)
                {
                    Console.WriteLine(kurs);
                }
            }
        }
    }


        
    
