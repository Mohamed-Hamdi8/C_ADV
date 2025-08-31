using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01
{
    internal class FixedSizeList<T>
    {
        internal T[] _items;
        internal int Count;
        private static readonly T[] s_emptyArray = new T[0];
        public FixedSizeList(uint capacity)
        {
            if (capacity == 0)
                _items = s_emptyArray;
            else
                _items = new T[capacity];
        }
        public void Add(T item)
        {
            if(Count ==_items.Length)
            {
                throw new ArgumentException("Out Of Range");
            }
            _items[Count++] = item;
        }
        public T this[int index]
        {
            get
            {
                if(index>=0 && index<Count)
                    return _items[index];
                else
                    throw new ArgumentException("Invalid indices");
            }
        }
    }
}
