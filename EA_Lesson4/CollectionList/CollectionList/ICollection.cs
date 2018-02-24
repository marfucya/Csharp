using System;
namespace Collection
{
    public interface ICollection<T>
    {
        int Count { get; } 
        void Add(T item);
        void CopyTo(T[] array, int arrayIndex);
        bool Contains(T item);
        bool IsReadOnly { get; }
        bool Remove(T item);
        void Clear();

    }
}
