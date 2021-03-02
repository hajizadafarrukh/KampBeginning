using System;

namespace Interfaces
{
    partial class Program
    {
        class PersonManager
        {
            public void Add(IPerson person)
            {
                Console.WriteLine(person.FirstName+" Eklendi");
            }
        }
    }
}
