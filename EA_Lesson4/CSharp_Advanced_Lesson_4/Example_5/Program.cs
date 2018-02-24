using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>()
            {
                1, 23, 31, 10, 35, 62, 21, 98, 34, 1, 2, 43, 5
            };

            foreach (int item in list)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();

            //list.Sort(new Comparison<int>(Comparer));

            //list.Sort(Comparer);

            //list.Sort(delegate (int a, int b) { return b - a; }); // Анонимный метод
            //list.Sort((int a, int b) => { return b - a; });       // Лямбда оператор
            list.Sort((a, b) =>  b - a);                            // Лямюда выражение

            foreach (int item in list)
            {
                Console.Write($"{item} ");
            }

            Console.ReadKey();
        }
        static int Comparer(int a, int b)
        {
            return b - a;
        }
    }
}
