using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName +" isimli urun Basariyla Eklendi");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " isimli urun Basariyla Guncellendi");
        }



        //ornek uchun

        public int Topla(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            return toplam;
        }
        //bir verini return etmek ucun public int yazdig
        public void Topla2(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine(toplam);
        }
        //publc void sadece yazdirmag uchundur 

    }
}
