using System;
using System.Collections.Generic;
using System.Text;

namespace Constructors
{
    class Customer
    {
        //default constructor- kendisi otomatik calisir, varsa bizimki calisir yoksa default kendisi calisir
        public Customer()
        {

        }
        public Customer(string Ad,string Soyad,int Idnumara,string city)
        {
            FirstName = Ad;
            LastName = Soyad;
            Id = Idnumara;
            City = city;

        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }
        public string City { get; set; }
    }
}
