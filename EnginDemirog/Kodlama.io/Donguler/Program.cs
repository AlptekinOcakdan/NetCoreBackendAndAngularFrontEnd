using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //array
            string[] kurslar = new string[]
            {
                "Yazılım Gelliştirme Kampı",
                "Programlamaya başlamak için temel kurs",
                "Java"
            };

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