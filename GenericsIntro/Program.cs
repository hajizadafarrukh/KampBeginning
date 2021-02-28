using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList <string> isimler = new MyList<string>();
            isimler.Plus("Faruk");
            isimler.Plus("Engin");
            isimler.Plus("hello");
            isimler.Plus("Mirza");

            Console.WriteLine(isimler.Uzunluk);
            isimler.Plus("Mirza");

            Console.WriteLine(isimler.Uzunluk);
            isimler.Plus("Mirza");

            Console.WriteLine(isimler.Uzunluk);

            foreach (var isim in isimler.Items)
            {
                Console.WriteLine(isim);
            }

        }
    }
}
