using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_2
{
    class Collection : IEnumerable
    {
        string[] str = null;
        public Collection(string s1, string s2, string s3)
        {
            str = new string[3];
            str[0] = s1;
            str[1] = s2;
            str[2] = s3;
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < str.Length; i++)
            {
                yield return str[i];
                if(str[i] == "hello 2")
                {
                    yield break;
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Collection str = new Collection("hello 1", "hello 2", "hello 3");

            foreach (string item in str)
            {
                Console.WriteLine(item);
            }


            Console.ReadLine();
        }
    }
}
