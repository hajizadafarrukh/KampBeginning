using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.ProductId = 1;
            product1.ProductName = "Masa";
            product1.CategoryId = 00000;
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product()
            {
                ProductId = 2,
                ProductName = "Kalem",
                CategoryId = 11111,
                UnitPrice = 300,
                UnitsInStock = 5
            };


            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            productManager.Update(product2);
        }
    }
}
