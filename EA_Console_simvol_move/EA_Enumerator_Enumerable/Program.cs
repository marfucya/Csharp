using System;
using System.Collections;
namespace Ienum_Ienumble
{
    public class car
    {
        private int year; 
        private string brand; 
                            
        public car (string Brand, int Year)
        {
            brand = Brand;
            year = Year;
        }
       
        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public string Brand
        {
            get { return brand; }

            set { brand = value; }
        }
    }
  
    public class cars : IEnumerator, IEnumerable
    {
        private car[] carlist; 
        int position = -1; 

        public cars()
        {
            carlist = new car[6]
            {
                new car("Ford",1992),
                new car("Fiat",1988),
                new car("Buick",1932),
                new car("Ford",1932),
                new car("Dodge",1999),
                new car("Honda",1977)
            };
        }
       
        public IEnumerator GetEnumerator() 
        { 
            return (IEnumerator)this;
        }
       
        public bool MoveNext() 
        {
            position++;
            return (position < carlist.Length);
        }

        public void Reset() 
        {
            position = 0; 
        }

        public object Current 
        {
            get { return carlist[position]; }
        }
    }

    class Program
    {
        public static void Main()
        {
            cars C = new cars();

            Console.WriteLine("Коллекция авто:");

            foreach (car c in C)
                
                Console.WriteLine(c.Brand + "\t\t" + c.Year);

            Console.ReadKey();
        }
    }
}