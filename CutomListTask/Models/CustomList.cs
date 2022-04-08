using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CutomListTask.Models
{
    class CustomList<T> : IEnumerable<T>
    {
        private static T[] _storage;
        private int _capacity;
        private int _count;
        public T this[int index]
        {
            get
            {
                if (index < Count && index >= 0)
                {
                    return _storage[index];
                }
                throw new IndexOutOfRangeException();
            }
            set
            {
                if (index < Count && index >= 0)
                {
                    _storage[index] = value;
                }
                throw new IndexOutOfRangeException();
            }
        }
        public int Count
        {
            get { return _count; }
            set
            {
                if (value < 0)
                {
                    throw new IndexOutOfRangeException();
                }
                _count = value;
            }
        }
        public int Capacity
        {
            get
            {
                return _capacity;
            }
            set
            {
                if (value <= 1)
                {
                    throw new IndexOutOfRangeException();
                }
                _capacity = value;
            }
        }
        public CustomList() : this(10) { }

        public CustomList(int capacity)
        {
            Capacity = capacity;
            _storage = new T[capacity];
        }

        public void Add(T input)
        {
            if (Count == Capacity)
            {
                CustomResize();
            }
            _storage[Count] = input;
            Count++;
        }
        public void CustomResize()
        {
            T[] newArray = new T[Capacity + 10];
            for (int i = 0; i < Capacity; i++)
            {
                newArray[i] = _storage[i];
            }
            _storage = newArray;
            Capacity += 10;
        }
        public bool CustomContains(T wanted)
        {
            foreach (T item in _storage)
            {
                if (item.Equals(wanted))
                {
                    return true;
                }
            }
            return false;
        }
        public void CustomInsert(T input, int index)
        {
            if (Count == Capacity)
            {
                CustomResize();
            }
            T[] newArray = new T[Capacity];
            for (int i = 0; i < Capacity; i++)
            {
                if (i == index)
                {
                    newArray[i] = input;
                    break;
                }
                newArray[i] = _storage[i];
            }
            for (int v = index+1; v < Capacity; v++)
            {
                newArray[v] = _storage[v];
            }
            _storage = newArray;
            Count++;
        }
        public void CustomInsert2(T input, int index)
        {
            if (Count == Capacity)
            {
                CustomResize();
            }
            for (int i = Count; i > index; i--)
            {
                _storage[i] = _storage[i - 1];
            }

        }
        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
