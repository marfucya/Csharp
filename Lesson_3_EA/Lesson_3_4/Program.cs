using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3_4
{
    class StrucCollection<T> where T : struct { }

    class RefCollection<T> where T : class { }

    class Program
    {
        static void Main(string[] args)
        {
            StrucCollection<int> intCollection = new StrucCollection<int>();
            StrucCollection<string> stringCollection = new StrucCollection<string>();

            RefCollection<int> intCollection1 = new RefCollection<int>();
            RefCollection<string> stringCollection1 = new RefCollection<string>();

            Console.ReadKey();
        }
    }
}
