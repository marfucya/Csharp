using System;

namespace lessons9
{
    class Program
    {
        static int[] MyReverse(int[] array)
        {
            int[] buf = new int[array.Length];

            for (int i = array.Length - 1, j = 0; 0 <= i; i--, j++)
            {
                buf[j] = array[i];                             
            }

            return buf;
        }

        static void Main()
        {
            int[] array = new int[5] { 1, 2, 3,  4, 5 };

            var res = MyReverse(array);

            for (int i = 0; i < res.Length; i++)
            {
                Console.WriteLine( res[i]);
            }

            Console.ReadKey();
        }
    }
}
