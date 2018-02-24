using System;

namespace lesson3._2
{
    class Program
    {
        static void Main()
        {
            double[] array = { 17, 31, 7 };
            double summ = 0;
            for (int i = 0; i < array.Length; i++)
                summ += array[i];
            double mid = summ / array.Length;
            Console.WriteLine(mid);
            Console.ReadKey();
        }
    }
}

//Используя Visual Studio, создайте проект по шаблону Console Application.
//Вычислите среднее арифметическое трех целочисленных значений и выведите его на экран.
//С какой проблемой вы столкнулись? Какой тип переменных лучше использовать для корректного
//отображения результата? 