using System;
using System.Collections.Generic;

namespace Collection
{

    class Program
    {
        static void Main(string[] args)
        {

            var test = new Collection<int>();

            Console.WriteLine(test.Count);

            test.Add(10);

            Console.WriteLine(test.Count);

            test.Add(11);

            Console.WriteLine(test.Count);

            test.Remove(11);

            Console.WriteLine(test.Count);

            test.Add(99);
            test.Add(88);

            foreach (var item in test)
            {
                Console.WriteLine( "item " + item);
            }

            Console.WriteLine(" ------- ");

            var enumerator = test.GetEnumerator();
            while (enumerator.MoveNext())
            {
                var item = enumerator.Current;
                Console.WriteLine("item " + item);
            }

            Console.ReadKey();
        }
    }
}
