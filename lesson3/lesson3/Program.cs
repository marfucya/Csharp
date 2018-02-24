using System;

namespace lesson3
{
    class Program
    {
        static void Main()
        {
            int x = 10; int y = 12; int z = 3;

            x += y - x++ * z;
            Console.WriteLine(x);

            z = --x - y * 5;
            Console.WriteLine(z);

            y /= x + 5 % z;
            Console.WriteLine(y);

            z = x++ + y * 5;
            Console.WriteLine(z);

            x = y - x++ * z;
            Console.WriteLine(x);

            Console.ReadKey();
        }
    }
}




















