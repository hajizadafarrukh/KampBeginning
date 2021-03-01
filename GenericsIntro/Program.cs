using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            MenimListem<string> Adlar = new MenimListem<string>();

            Adlar.Plus("Elnur");
            Adlar.Plus("Mirza");
            Adlar.Plus("Ferrux");
            Adlar.Plus("Engin");

            Console.WriteLine(Adlar.Uzunluk);

            foreach (var ad in Adlar.adlar)
            {
                Console.WriteLine(ad);
            }


            
            //Console.WriteLine(isimler.Uzunluk);

            //foreach (var isim in isimler.Items)
            //{
            //    Console.WriteLine(isim);
            //}

        }
    }
}
