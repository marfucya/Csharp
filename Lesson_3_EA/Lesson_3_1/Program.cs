using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dict = new Dictionary<int, string>(3);

            dict.Add(1, "First");
            dict.Add(2, "Second");

            dict.DispalyData();

            Console.ReadKey();
        }
    }

    class Dictionary<TKey, TValue>
    {
        private TKey[] keys;
        private TValue[] values;

        private int counter = 0;

        public Dictionary(int count)
        {
            keys = new TKey[count];
            values = new TValue[count];
        }

        public void Add(TKey key, TValue value)
        {
            if(counter < keys.Length)
            {
                keys[counter] = key;
                values[counter] = value;
                counter++;
            }
            else
            {
                Console.WriteLine("Dictionary is full");
            }
        }
        public void DispalyData()
        {
            for (int i = 0; i < counter; i++)
            {
                Console.WriteLine($"{keys[i]} - {values[i]}");
            }
        }

    }
}
