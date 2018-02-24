using System;

namespace Loop
{
    class Program
    {
        static void Main()
        {
            int i = 1; 
            do
            {
                i++;
                int j = 1;
                do
                {
                    j++;
                    Console.Write("{0}\t", i * j);
                }
                while (j < 11);
            }
            while (i < 11);
                Console.WriteLine();
            }

           
        }
    }

