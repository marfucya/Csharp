using System;

// Цикл for вложенный в цикл for. ( Построение квадрата из звездочек - * )

namespace Loop
{
    class Program
    {
        static void Main()
        {
            //прямоугольник
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("-", 20);


            //прямоугольный треугольник
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("-", 20);



            for (int i = 0; i < 10; i++)
            {
                // Выводим одну строку из 10 звездочек.
                for (int j = 0; j < 10; j++)
                {
                    Console.Write("*");
                }

                // Переход на новую строку.
                Console.WriteLine();
            }


            //ромб
            int i, j, N = 11;
            int center = N / 2;
            for (i = 0; i < N; i++)
            {
                for (j = 0; j < N; j++)
                {
                    if (i <= center)
                    {
                        // Верхняя половина ромба
                        if (j >= center - i && j <= center + i)
                            Console.Write("*");
                        else
                            Console.Write(" ");
                    }
                    else
                    {
                        // Нижняя половина ромба
                        if (j >= center + i - N + 1 && j <= center - i + N - 1)
                            Console.Write("*");
                        else
                            Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
           
            // Delay.
            Console.ReadKey();
        }
    }
}


//Используя циклы и метод:
//Console.Write("*"), Console.Write(" "), Console.Write("\n") (для перехода на новую строку).
//Выведите на экран:
//прямоугольник
// прямоугольный треугольник
// равносторонний треугольник
//ромб
