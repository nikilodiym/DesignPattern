using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_5.Iterator
{
    public class ConcreteIterator<T> : IIterator<T>
    {
        private readonly List<T> _items;
        private int _currentIndex = 0;

        public ConcreteIterator(List<T> items) => _items = items;
        public bool HasNext() => _currentIndex < _items.Count;
        public T Current() => _items[_currentIndex];
        public void Next() => _currentIndex++;
    }
}
