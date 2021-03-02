namespace InterfacesDemo
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Iworker[] workers = new Iworker[3]
            {
                new Manager(),
                new Robot(),
                new Worker()
             };
            foreach (var worker in workers)
            {
                worker.Work();
            }

            IEat[] eats = new IEat[2]
            {
                new Manager(),
                
                new Worker()
            };

            IGetSalary[] getSalaries = new IGetSalary[2]
            {
                new Manager(),
                new Worker(),
               
            };

        }

    }

    
}
