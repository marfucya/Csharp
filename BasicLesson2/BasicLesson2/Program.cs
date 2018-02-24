using System;

namespace BasicLesson2
{
    class Converter
    {
        double usd;
        double eur;
        double rub;

        public Converter(double usd, double eur, double rub)
        {
            this.usd = usd;
            this.eur = eur;
            this.rub = rub;
        }
    }

    class Usd
    {
        double chench;
        public void UsdConverter(double hrivna, double kurs)
        {
            chench = hrivna * kurs;
            Console.WriteLine("{0} usd  = {1} hrivna", hrivna, chench );

            chench =  hrivna / kurs;
            Console.WriteLine("{0} hrivna = {1} usd", hrivna, chench);
        }

    }

        class Program
        {
            static void Main()
            {
                
                Usd usd = new Usd();

                usd.UsdConverter(2,30);


            Console.ReadKey();
            }
        }
}


