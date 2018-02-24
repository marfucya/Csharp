using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_1
{

    class Program
    {
        static void Main(string[] args)
        {
            //ICollection<>
            //IList<>

            CarCollection<Car> cars = new CarCollection<Car>()
            {
                new Car() { Name = "Volvo" },
                new Car() { Name = "BMW" },
                new Car() { Name = "Toyota" },
                new Car() { Name = "Lada" }
            };

            Console.WriteLine(new string('-', 50));

            Console.WriteLine($"Количество элементов в коллекции = {cars.collection.Length}");

            Console.WriteLine(new string('-', 50));

            foreach (Car item in cars)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }

    class CarCollection<T> : ICollection<T>, IEnumerable<T>, IEnumerable
    {
        public T[] collection;
        int counter;
        int count = 0;  //счетчик 

        public CarCollection()
        {
            this.collection = new T[1];
        }
        public CarCollection(int count)
        {
            collection = new T[count];
        }

        #region "Методы интефейса ICollection<T>"
        public int Count
        {
            get
            {
                return this.count;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        public void Add(T car)
        {
            if (counter < this.collection.Length)
            {
                this.collection[counter] = car;
            }
            else
            {
                T[] tmp = new T[this.collection.Length * 2];
                this.CopyTo(tmp, 0);
                this.collection[counter] = car;
            }
            counter++;
            count++;
        }

        public void Clear()
        {
            this.counter = 0;
            this.count = 0;
            this.collection = new T[0];
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            for (int i = arrayIndex; i < Count; i++)
            {
                array[i] = this.collection[i];
            }
            this.collection = array;
        }

        public bool Remove(T item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (this.collection[i].ToString() == item.ToString())
                {
                    this.CopyTo(this.collection, i);
                    return true;
                }
            }
            return false;
        }
        #endregion

        IEnumerator IEnumerable.GetEnumerator()
        {
            return null;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new CarEnumerator<T>(this);
        }

        struct CarEnumerator<T> : IEnumerator<T>, IEnumerator
        {
            CarCollection<T> collection;
            int pointer;
            public CarEnumerator(CarCollection<T> collection)
            {
                this.collection = collection;
                pointer = -1;
            }

            object IEnumerator.Current
            {
                get
                {
                    return collection.collection[pointer];
                }
            }

            public T Current
            {
                get
                {
                    return this.collection.collection[pointer];
                }
            }

            public void Dispose()
            {
                Reset();
            }

            public bool MoveNext()
            {
                if (pointer < collection.collection.Length - 1)
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
        }
    }


    class Car
    {
        public string Name { get; set; }
        public override string ToString()
        {
            return this.Name;
        }
    }
}
