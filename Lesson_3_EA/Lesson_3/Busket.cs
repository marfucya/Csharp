using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3
{
    class Busket<T>
    {
        private T[] array;
        private int counter = 0;

        public Busket(int count)
        {
            array = new T[count];
        }

        public void Add(T item)
        {
            if(counter < array.Length)
            {
                array[counter] = item;
                counter++;
            }
            else
            {
                Console.WriteLine("Collection is full");
            }
        }

        public void DisplayDataTypeOfElements()
        {
            Console.WriteLine($"Type of inner array : {array.GetType()}");
        }
        public void DisplayData()
        {
            foreach (T item in this.array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
