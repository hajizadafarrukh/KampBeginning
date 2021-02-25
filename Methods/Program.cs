using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            

            Product product1 = new Product();

            product1.Name = "Elma";
            product1.Id = 123;
            product1.Price = 15;
            product1.Info = "Amasya Elmasi";

            Product product2 = new Product();
            product2.Name = "Karpuz";
            product2.Id = 234;
            product2.Price = 80;
            product2.Info = "DIyarbakir Karpuzu";

            Product[] products = new Product[] {product1,product2 };

            foreach (Product product in products)
            {
                Console.WriteLine(product.Name+", "+product.Id+", "+product.Price+" TL, "+product.Info);
            }

            Console.WriteLine("--------------Metotlar-----------------");

            SepetManager sepetManager = new SepetManager();

            sepetManager.Add(product1);

            sepetManager.Add(product2);

            sepetManager.Remove(product1);

            sepetManager.Add2("Armut", "Yesil armut", 12);
            
        }
    }
}



//do not repeat yourself - kendini tekrar etme 
