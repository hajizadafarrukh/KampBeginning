using System;

namespace InterfacesDemo
{
    partial class Program
    {
        class Manager : Iworker, IEat, IGetSalary
        {
            public void Eat()
            {
                throw new NotImplementedException();
            }

            public void Salary()
            {
                throw new NotImplementedException();
            }

            public void Work()
            {
                throw new NotImplementedException();
            }
        }
    }
}
