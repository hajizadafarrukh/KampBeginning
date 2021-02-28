using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("Ganja");

            Console.WriteLine(sehirler.Count);


            OurList<string> sehirler2 = new OurList<string>();
            sehirler2.Ekle("Ganja");
            Console.WriteLine(sehirler2.Count);
            sehirler2.Ekle("Ganja");
            Console.WriteLine(sehirler2.Count);
            sehirler2.Ekle("Ganja");
            Console.WriteLine(sehirler2.Count);
            sehirler2.Ekle("Ganja");
            Console.WriteLine(sehirler2.Count);

            foreach (var sehir in sehirler2.Array)
            {
                Console.WriteLine(sehir);
            }

        }




        class OurList<T> //Generic Class
        {
            T[] array;
            T[] temparray;
            public OurList()
            {
                array = new T[0];
            }
            public void Ekle(T item)
            {
                temparray = array;
                array = new T[array.Length + 1];
                for (int i = 0; i < temparray.Length; i++)
                {
                    array[i] = temparray[i];

                }
                array[array.Length - 1] = item;

            }


            public int Count
            {
                get { return array.Length; }

            }

            public T[] Array
            {
                get { return array; }
            }



        }
    }
}

