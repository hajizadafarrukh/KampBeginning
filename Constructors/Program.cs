using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            // Constructor- yapici demek

            Customer customer = new Customer() { Id = 1, FirstName = "Engin", 
                LastName = "Demirov", City = "Diyarbakir" };


            Customer customer2 = new Customer();
            customer2.FirstName = "Mirza";
            customer2.LastName="Ismayilov";


            Customer customer1 = new Customer("Faruk", "Hacizade", 2, "Ganja");
            

            Console.WriteLine(customer1.FirstName);
        }
    }


}
