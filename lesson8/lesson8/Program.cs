using System;

namespace lesson8
{
    class Program
    {
        static int Dostavka(int Costomer)
        {
            if (Costomer == 0)
                return 1;
            else
                return Costomer * Dostavka(Costomer - 1);
        }

        static void Main()
        {
            int dostavka = Dostavka(5);

            Console.WriteLine(dostavka);

            Console.ReadKey();
        }
    }
}
