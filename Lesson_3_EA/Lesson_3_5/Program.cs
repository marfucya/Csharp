using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            CarCollection<Car> carCollection = new CarCollection<Car>();

            carCollection.Add(new Car() { Name = "BMW" });
            carCollection.Add(new Car() { Name = "Mercedes" });
            carCollection.Add(new Car() { Name = "Volkswagen" });
            carCollection.Add(new Car() { Name = "Volvo" });
            carCollection.Add(new Car() { Name = "Toyota" });


            IEnumerator<Car> carEnumerator = carCollection.GetEnumerator();

            //while (carEnumerator.MoveNext())
            //{
            //    Car concreteCar = carEnumerator.Current;
            //    Console.WriteLine(concreteCar.Name);
            //}

            //Console.WriteLine(new string('-', 50));

            //while (carEnumerator.MoveNext())
            //{
            //    Car concreteCar = carEnumerator.Current;
            //    Console.WriteLine(concreteCar.Name);
            //}


            foreach (Car item in carCollection)
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine(new string('-', 50));

            foreach (Car item in carCollection)
            {
                Console.WriteLine(item.Name);
            }

            Console.ReadKey();
        }
    }


    class CarCollection<T> : IEnumerable<T>, IEnumerator<T>, IEnumerator, IDisposable
    {
        List<T> collections = new List<T>();

        int pointer = -1;

        public T Current
        {
            get
            {
                return collections[pointer];
            }
        }

        object IEnumerator.Current
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Add(T item)
        {
            collections.Add(item);
        }

        public void Dispose()
        {
            this.Reset();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this as IEnumerator<T>;
        }

        public bool MoveNext()
        {
            if(pointer < collections.Count - 1)
            {
                pointer++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Reset()
        {
            this.pointer = -1;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }


    class Car
    {
        public string Name { get; set; }
    }

}
