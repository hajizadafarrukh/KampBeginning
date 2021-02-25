using System;
using System.Collections.Generic;
using System.Text;

namespace Math
{
    class FourOperation
    {
        public void Add(int number1, int number2)
        {
            int sum = number1 + number2;
            Console.WriteLine("Add metodunun verdiyi sonuc: "+sum);
        }

        public void Extract(int number1, int number2)
        {
            int extraction = number1 - number2;
            Console.WriteLine("Extract metodunun verdiyi sonuc: "+extraction);
        }

        public void Multiply(int number1, int number2)
        {
            int multiplication = number1 * number2;
            Console.WriteLine("Multiply metodunun verdiyi sonuc: "+multiplication);
        }

        public void Divide(int number1, int number2)
        {
            double division = number1 / number2;
            Console.WriteLine("Divide metodunun verdiyi sonuc: " + division);
        }
    }
}
