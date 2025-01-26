using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvC_01
{
    public class FixedSizeList<T>
    {
        private readonly List<T> _list;
        private readonly int _capacity;

        public FixedSizeList(int capacity)
        {
            if (capacity <= 0)
                throw new ArgumentException("Capacity must be greater than 0.");

            _capacity = capacity;
            _list = new List<T>();
        }

        public void Add(T item)
        {
            if (_list.Count >= _capacity)
                throw new InvalidOperationException("The list is full.");

            _list.Add(item);
        }

        public T Get(int index)
        {
            if (index < 0 || index >= _list.Count)
                throw new IndexOutOfRangeException("Index is out of range.");

            return _list[index];
        }
    }


}
