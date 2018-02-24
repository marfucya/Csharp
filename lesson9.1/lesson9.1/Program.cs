using System;

namespace lesson9._1
{
    class Program
    {
        
    }

    static void Main()
    {
        int[] array = new int[] { };
        Random rand = new Random();
        for (int i = 0; i < array.Length; i++)
            array[i] = rand.Next(-100, 100);


        Console.WriteLine(array);


        Console.ReadKey();
    }
}

//Создать массив размера N элементов, заполнить его произвольными целыми значениями(размер массива задает пользователь).
//Вывести на экран: наибольшее значение массива, наименьшее значение массива, общую сумму всех элементов,
//среднее арифметическое всех элементов, вывести все нечетные значения.



