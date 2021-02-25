using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class SepetManager
    {
        //naming convention- isimlendirme kurali
        public void Add(Product product)
        {
            Console.WriteLine("Sepete Eklendi"+": "+product.Name);
        }

        public void Remove(Product product)
        {
            Console.WriteLine("Sepetten cikarildi" +": "+ product.Name);
        }

        public void Add2(string Name, string Info, double Price )
        {
            //bunu kullanma 
            Console.WriteLine("Sepete Eklendi" + ": " + Name);
        }
    }
}
