using System;
using System.Collections.Generic;

namespace Collection
{
    public class Collection<T> : ICollection<T>
    {

        private T[] items;

        public Collection()
        {
            items = new T[0];
        }

        public int Count
        {
            get => items.Length;
        }

        public void Add(T item)
        {
            T[] newStore = new T[items.Length + 1];
            for (int i = 0; i < items.Length; i++)
            {
                newStore[i] = items[i];
            }
            newStore[newStore.Length - 1] = item;
            items = newStore;
        }


        public void CopyTo(T[] array, int index)
        {
            foreach (T i in array)
            {
                array.SetValue(i, index);
                index = index + 1;
            }
        }

        public bool Contains(T item)
        {
            bool contains = false;
            for (int i = 0; i < items.Length; i++)
            {
                if (EqualityComparer<T>.Default.Equals(items[i], item))
                {
                    contains = true;
                    break;
                }
            }
            return contains;
        }

        public bool IsReadOnly
        {
            get => items.IsReadOnly;
        }

        public bool Remove(T item)
        {
            int containsOnIndex = -1;
            for (int i = 0; i < items.Length; i++)
            {
                if (EqualityComparer<T>.Default.Equals(items[i], item))
                {
                    containsOnIndex = i;
                    break;
                }
            }
            if (containsOnIndex >= 0)
            {
                T[] newStore = new T[items.Length - 1];
                int matched = 0;
                for (int i = 0; i < items.Length; i++)
                {
                    if (i == containsOnIndex)
                    {
                        matched++;
                        continue;
                    }
                    newStore[i] = items[i - matched];
                }
                items = newStore;
            }
            return containsOnIndex >= 0;
        }

        public void Clear()
        {
            items = new T[0];
        }

        public MyEnumerator GetEnumerator() 
        {
            return new MyEnumerator(this);
        }
         
        public class MyEnumerator
        {
            int nIndex;
            Collection<T> collection;
            public MyEnumerator(Collection<T> coll)
            {
                collection = coll;
                nIndex = -1;
            }

            public bool MoveNext()
            {
                nIndex++;
                return (nIndex < collection.items.GetLength(0));
            }

            public T Current
            {
                get
                {
                    return (collection.items[nIndex]);
                }
            }

            public void Reset()
            {
                nIndex = -1;
            }

        }

    }

}