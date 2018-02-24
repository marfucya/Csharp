using System;

namespace lesson8._1
{
    class Program
    {
        static int wholecredit = 700;

        static void Banking(int payment)
        {

            int ostatok = wholecredit - payment;
            int pereplata = payment - wholecredit;

            if (payment < wholecredit)
                Console.WriteLine("Вам осталось внести: {0}", ostatok);
           
            if (payment > wholecredit)
               Console.WriteLine("Переплата: {0}", pereplata);

            if (payment == wholecredit)
                Console.WriteLine("кредит погашен!");
            
            Console.WriteLine();
        }


        static void Main(string[] args)
        {

            Banking(890);
            //Banking(300);
           // Banking(10);
            //Banking(200);
            Console.ReadKey();
        }
    }

     


}


//Представьте, что вы реализуете программу для банка, которая помогает определить, 
//погасил ли клиент кредит или нет.Допустим, ежемесячная сумма платежа должна составлять 100 грн.
//Клиент должен выполнить 7 платежей, но может платить реже большими суммами
//.Т.е., может двумя платежами по 300 и 400 грн.Закрыть весь долг.
//Создайте метод, который будет в качестве аргумента принимать сумму платежа, введенную экономистом банк
//а.Метод выводит на экран информацию о состоянии кредита (сумма задолженности, сумма переплаты, сообщение об отсутствии долга).