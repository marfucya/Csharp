using System;

namespace Loop
{
    class Program
    {
        static void Main()
        {
            int i = 1;
            while ( i < 11)
            {
                int j = 1;
                while ( j < 11)
                {
                    Console.Write("{0}\t", i * j);
                    j++;

                }
                i++;

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
