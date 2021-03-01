using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {

            GercekMusteri gercekMusteri1 = new GercekMusteri();
            gercekMusteri1.Id = 1;
            gercekMusteri1.MusteriNo = "12345";
            gercekMusteri1.Adi = "Faruk";
            gercekMusteri1.Soyadi = "Hacizade";
            gercekMusteri1.TcNo = "99499456498";

            //Kodlama.io

            TuzelMusteri tuzelMusteri1 = new TuzelMusteri();
            tuzelMusteri1.Id = 2;
            tuzelMusteri1.MusteriNo = "54321";
            tuzelMusteri1.SirketAdi = "Kodlama.io";
            tuzelMusteri1.VergiNo = "123456789";



            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri3);
            musteriManager.Ekle(tuzelMusteri1);
            musteriManager.Ekle(gercekMusteri1);
            musteriManager.Ekle(musteri4);



            //Gercek musteri- Tuzel musteri
            //SOLID 


        }
    }
}
