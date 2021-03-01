﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MenimListem<T>
    {
        T[] items;
        //constructor
        public MenimListem()
        {
            items = new T[0];
        }
        public void Plus(T item)
        {
            T[] tempArray = items;
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;

        }

        public int Uzunluk
        {
            get { return items.Length; }
        }

        public T[] adlar
        {
            get { return items; }

        }



    }
}
