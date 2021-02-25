using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazilim Gelistiri Yetistirme Kampi";
            string kurs2 = "Programlaya bbaslangic icin temel kurs";
            string kurs3 = "Java";

            //arrays- diziler

            string[] kurslar = new string[] { "Yazilim Gelistiri Yetistirme Kampi", 
                "Programlaya bbaslangic icin temel kurs", 
                "Java" ,"Python","C#"};





            for (int i = 0; i < kurslar.Length; i++)
            { 
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For bitti");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa sonu - footer");
        }
    }
}
