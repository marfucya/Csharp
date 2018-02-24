using System;

namespace EA_Lesson4
{
    public delegate int Del(int a, int b);

    public class Me
    {

        public static int Sum(int a, int b)
        {
            int sum;
            return sum = a + b;
        }
    }
        class Program
     {
        static void Main(string[] args)
        {
            //Del del = new Del(Me.Sum);

            //Console.WriteLine(del(4,7));

            var test = new MyList<int>();
            test.Add(100);
            test.Show();

            Console.ReadKey( );
        }
    }
}
