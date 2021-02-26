using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork
{
    class MusteriManager
    {
        public void MusteriEkleme(Musteri musteri)
        {
            Console.WriteLine("Tebrikler! "+musteri.Adi+" "+musteri.Soyadi +" basariyla eklendi!");
        }

        public void MusteriSilme(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi+" "+musteri.Soyadi + " sistemden basariyla silindi");
        }

        public void MusteriListele(Musteri[] musteris)
        {
            foreach (var musteri in musteris)
            {
                Console.WriteLine(musteri.Adi+" "+musteri.Soyadi+" " + musteri.BabaAdi);
            }
        }
    }
}
