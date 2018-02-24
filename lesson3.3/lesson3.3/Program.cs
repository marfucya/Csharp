using System;

namespace lesson3._3
{
    class Program
    {


        static void PolorOtr(int a)
        {
            if (a<0)
                Console.WriteLine("отрицательное");
            else
                Console.WriteLine("положительное");
            
        }

        static void Prostoe (int b)
        {
            if (b % 1 == 0 && b % b == 0 && b % 2 != 0)
                Console.WriteLine("простое");
            else
                Console.WriteLine("не простое");
        }

       // static bool Delenie (int c)
       // {

        //    if (c % )
      //  }

        static void Main()
        {
            Console.WriteLine("Введите положительное или отрицательное число");
            var a = Convert.ToInt32(Console.ReadLine());
            PolorOtr(a);
            //Console.WriteLine(PolorOtr(a));


            Console.WriteLine("Введите число");
            var b = Convert.ToInt32(Console.ReadLine());
            Prostoe(b);

           

            Console.ReadKey();
        }
       
     }
}


//Представьте, что вы реализуете программу для банка, которая помогает определить, 
//погасил ли клиент кредит или нет.Допустим, ежемесячная сумма платежа должна составлять 100 грн.
//Клиент должен выполнить 7 платежей, но может платить реже большими суммами
//.Т.е., может двумя платежами по 300 и 400 грн.Закрыть весь долг.
//Создайте метод, который будет в качестве аргумента принимать сумму платежа
//, введенную экономистом банка.Метод выводит на экран информацию о состоянии кредита 
//(сумма задолженности, сумма переплаты, сообщение об отсутствии долга).


