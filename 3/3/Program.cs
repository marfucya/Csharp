using System;

namespace _3
{
 // Создать класс с двумя переменными.Добавить функцию вывода на экран и функцию 
 //изменения этих переменных.Добавить функцию, которая находит сумму значений этих
 //переменных, и функцию которая находит наибольшее значение из этих двух переменных.

    class Program
    {
        public static void Print(int a, int  b)
        {
            Console.WriteLine(a);
            Console.WriteLine(b);
        }

        public static void Change (int a, int b)
        {
            a = a * a;
            b = b - a;
            Console.WriteLine(a);
            Console.WriteLine(b);
        }

        public static int Sum(int a, int b)
        {
            int c;
            return c = a + b;
        }

        public static int Max (int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else return b;
        }

        static void Main()
        {
            int a = 8;
            int b = 9;

            Print(a, b);
            Change(a, b);
            Console.WriteLine(Sum(a,b));
            Console.WriteLine(Max(a, b));

            Console.ReadKey();
        }
    }
}
