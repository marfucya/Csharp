using System;

namespace Vusluga
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите выслугу лет");
            double years = Convert.ToInt32(Console.ReadLine());
            int salery = 2000;
            //Console.WriteLine("years " + years );
            if (years > 0 && years < 5)
            {
                double vusluga = salery * 0.1;
                double vusluga_salery = salery + vusluga;
                Console.WriteLine("Выслуга до 5 лет, премия составляет 10% от заработной платы - " + vusluga +
                                   ", всего зарплата равна " + vusluga_salery);
            }
            else if (years >= 5 && years < 10)
            {
                double vusluga = salery * 0.15;
                double vusluga_salery = salery + vusluga;
                Console.WriteLine("Выслуга от 5 лет (включительно) до 10 лет, премия составляет 15% от заработной платы - " + vusluga +
                                   ", всего зарплата равна " + vusluga_salery);
            }
            else if (years >= 10 && years < 15)
            {
                double vusluga = salery * 0.15;
                double vusluga_salery = salery + vusluga;
                Console.WriteLine("Выслуга от 10 лет (включительно) до 15 лет, премия составляет 15% от заработной платы - " + vusluga +
                                   ", всего зарплата равна " + vusluga_salery);
            }
            else if (years >= 15 && years < 20)
            {
                double vusluga = salery * 0.15;
                double vusluga_salery = salery + vusluga;
                Console.WriteLine("Выслуга от 15 лет (включительно) до 20 лет, премия составляет 15% от заработной платы - " + vusluga +
                                   ", всего зарплата равна " + vusluga_salery);
            }
            else if (years >= 20 && years < 25)
            {
                double vusluga = salery * 0.15;
                double vusluga_salery = salery + vusluga;
                Console.WriteLine("Выслуга от 20 лет (включительно) до 25 лет, премия составляет 15% от заработной платы - " + vusluga +
                                   ", всего зарплата равна " + vusluga_salery);
            }
            else
            {
                double vusluga = salery * 0.15;
                double vusluga_salery = salery + vusluga;
                Console.WriteLine("Выслуга от 25 лет премия составляет 15% от заработной платы - " + vusluga +
                                   ", всего зарплата равна " + vusluga_salery);
            }
        }
    }
}