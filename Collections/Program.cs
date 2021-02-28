using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] collections = new string[] { "Engin", "Mirza", "Elnur", "Ferrux",null };
            //Console.WriteLine(collections[0]);
            //Console.WriteLine(collections[1]);
            //Console.WriteLine(collections[2]);
            //Console.WriteLine(collections[3]);
            //collections[4] = "Ilker";

            //console.writeline(collections[4]);

            List<string> isimler2 = new List<string>() { "Engin", "Mirza", "Elnur", "Ferrux" };

            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            

            isimler2.Add("Memi");
            Console.WriteLine(isimler2[4]);



        }
    }
}
