using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3
{
    class Apple
    {
        public string Name { get; set; }

        public override string ToString()
        {
            return this.Name;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Busket<int> busket = new Busket<int>(5);
            busket.Add(10);
            busket.Add(20);
            busket.Add(30);
            busket.Add(40);
            busket.Add(50);
            busket.DisplayDataTypeOfElements();
            busket.DisplayData();

            Busket<Apple> applesBusket = new Busket<Apple>(5);
            applesBusket.Add(new Apple() { Name = "Apple 1"});
            applesBusket.Add(new Apple() { Name = "Apple 2" });
            applesBusket.Add(new Apple() { Name = "Apple 3" });
            applesBusket.Add(new Apple() { Name = "Apple 4" });
            applesBusket.Add(new Apple() { Name = "Apple 5" });
            applesBusket.DisplayDataTypeOfElements();
            applesBusket.DisplayData();


            Console.ReadLine();
        }
    }
}

// int a = 10;
// object obj1 = a;    // Упаковка
// int a1 = (int)obj1; // Распаковка

// Console.WriteLine(a1);

// double d1 = (double)(int)obj1;
// Console.WriteLine(d1);
