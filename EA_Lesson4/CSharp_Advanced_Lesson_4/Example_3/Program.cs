using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_3
{
    public delegate void Sum(int result);
    class Program
    {
        static void SumDigit(int value1, int value2, Sum sum)
        {
            int summa = value1 + value2;          

            if(sum == null)
            {
                Console.WriteLine($"Сумма чисел {value1} + {value2} = {summa}");
                return;
            }
            sum.Invoke(summa);
        } 
        
        public static void GetSum(int result)
        {
            Console.WriteLine($"Результат операции сложения равен {result}");
            Console.WriteLine($"Вычесленное значение равно {result / 2}");
        }

        static void Main(string[] args)
        {
            
            //SumDigit(10, 3, new Sum(GetSum));
            SumDigit(10, 3, GetSum);

            Console.ReadKey();
        }
    }
}
