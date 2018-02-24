using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leson_3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> intCollection = new List<double>();
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Peek();
            queue.Dequeue();


            Stack<double> stack = new Stack<double>();
            stack.Push(2.3);
            stack.Peek();
            stack.Pop();

            Console.ReadKey();
        }
    }
}
