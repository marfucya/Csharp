using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_4
{
    public delegate int Delegate();


    class Program
    {
        static Random rand = new Random();

        //static int GetValue()
        //{
        //    return rand.Next(10, 20000);
        //}

        static void Main(string[] args)
        {
            //Delegate deleg = new Delegate(GetValue);
            Delegate deleg = delegate () { return rand.Next(10, 20000); }; // Подписка

            deleg -= delegate () { return rand.Next(10, 20000); }; // ОТписать анонимный метод от класса делегата невозможно!!!!
            Console.WriteLine(deleg.Invoke());

            deleg = null;

            deleg = () => rand.Next(10, 20000);


            // deleg.Invoke();
            Console.ReadLine();
        }
    }
}
