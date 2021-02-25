using System;

namespace Math
{
    class Program
    {
        static void Main(string[] args)
        {
            FourOperation fourOperation = new FourOperation();

            fourOperation.Add(5, 6);

            fourOperation.Divide(16, 5);

            fourOperation.Extract(11, 1);

            fourOperation.Multiply(15, 12);
        }
    }
}
