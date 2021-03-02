namespace InterfacesDemo
{
    partial class Program
    {
        class Worker : Iworker, IEat, IGetSalary
        {
            public void Eat()
            {
                throw new System.NotImplementedException();
            }

            public void Salary()
            {
                throw new System.NotImplementedException();
            }

            public void Work()
            {
                throw new System.NotImplementedException();
            }
        }

    }

    
}
