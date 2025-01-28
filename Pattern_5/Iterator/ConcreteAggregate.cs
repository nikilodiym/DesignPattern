using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_5.Iterator
{
    public class ConcreteAggregate<T> : IAggregate<T>
    {
        private readonly List<T> _items = new();
        public void Add(T item) => _items.Add(item);
        public IIterator<T> CreateIterator() => new ConcreteIterator<T>(_items);
    }
}
