using System;

namespace KampOdev1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product cigarette = new Product();
            cigarette.ProductName = "Camel Slender Blue";
            cigarette.ProductNumber = 10;
            cigarette.ProductPrice = 14.50;

            Product alcohol = new Product();
            alcohol.ProductName = "Efes Malt";
            alcohol.ProductNumber = 5;
            alcohol.ProductPrice = 12.50;


            Product chocolate = new Product();
            chocolate.ProductName = "Snickers";
            chocolate.ProductNumber = 2;
            chocolate.ProductPrice = 4.75;


            Product[] products = new Product[] { cigarette, alcohol, chocolate };

            //using for loop

            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].ProductName + ",  " + products[i].ProductNumber + " adet , " + products[i].ProductPrice + " TL");
            }

            //using foreach loop

            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Foreach dongusu kullanarak");

            foreach (Product product in products)
            {
                Console.WriteLine(product.ProductName + ",  " + product.ProductNumber + " adet , " + product.ProductPrice + " TL");
            }

            //using while loop

            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("While dongusu kullanarak");
            int o = 0;
            while (o < products.Length)
            {
                Console.WriteLine(products[o].ProductName + ",  " + products[o].ProductNumber + " adet ,  " + products[o].ProductPrice + " TL");
                o++;
            }
        }

        class Product
        {
            public string ProductName { get; set; }
            public int ProductNumber { get; set; }
            public double ProductPrice { get; set; }
        }
    }
}
