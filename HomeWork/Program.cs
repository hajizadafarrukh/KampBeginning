using System;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();            
            musteri1.Adi = "Faruk";
            musteri1.Soyadi = "Hacizade";
            musteri1.BabaAdi = "Yusif";
            musteri1.TcNumber = 999;

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Mirza";
            musteri2.Soyadi = "Ismayilov";
            musteri2.BabaAdi = "Fexreddin";
            musteri2.TcNumber = 888;


            Musteri musteri3 = new Musteri();
            musteri3.Adi = "Ilkin";
            musteri3.Soyadi = "Huseynli";
            musteri3.BabaAdi = "Elcin";
            musteri3.TcNumber = 777;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkleme(musteri1);
            musteriManager.MusteriEkleme(musteri2);
            musteriManager.MusteriEkleme(musteri3);
            musteriManager.MusteriSilme(musteri1);

            Console.WriteLine("------------Listele Metodu--------------------");

            musteriManager.MusteriListele(musteriler);

        }
    }
}
