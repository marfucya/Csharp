using System;
using System.Collections;
namespace ForEach
{
    public class A
    {
        static int n;

        public A (int N)
        {
            n = N; 
        }

        public IEnumerable MyEnumerator()
        {
            for (int i = 0; i < n; i++)
            yield return ("Hello World! " + System.Convert.ToString(i));
        }
    } 

    class Program
    {
        public static void Main()
        {

            A a = new A(5);

            foreach (string item in a.MyEnumerator())

            Console.WriteLine(item);
            
            Console.ReadKey();
        } 
    }
}