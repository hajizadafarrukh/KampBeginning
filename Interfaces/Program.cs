using System;

namespace Interfaces
{
    partial class Program
    {
        static void Main(string[] args)
        {
            // InterfacesIntro();
            // Demo();



        }

        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Ekle(new SqlServerCustomerDal());
            customerManager.Ekle(new OracleServerDal());
        }

        private static void InterfacesIntro()
        {
            PersonManager personManager = new PersonManager();

            Customer customer = new Customer()
            {
                Id = 1,
                FirstName = "Faruk",
                LastName = "Hacizade",
                Adress = "Yeni Gence"
            };

            Student student = new Student()
            {
                Id = 123,
                FirstName = "Mirza",
                LastName = "Ismayilov",
                Departmant = "Bilgisayar"

            };
            personManager.Add(student);
            personManager.Add(customer);
        }
    }
}
