using System;

namespace KampBeginning
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOran = 1.45;
            bool sistemeGirisYapmisMi = false;
            double dolarDUn = 7.35;
            double dolarBugun = 7.45;

            if (dolarDUn>dolarBugun)
            {
                Console.WriteLine("Azalis buton");
            }
            else if (dolarDUn<dolarBugun)
            {
                Console.WriteLine("Artis Butonu");
            }
            else
            {
                Console.WriteLine("Degismedi Butonu");
            }

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanici ayarlari butonu");
            }
            else
            {
                Console.WriteLine("Giris Yap Butonu");
            }

            Console.WriteLine(kategoriEtiketi);


        }
    }
}
