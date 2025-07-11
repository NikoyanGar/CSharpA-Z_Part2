using System.Collections;

namespace _008_IEnumerable_Perf
{
    public class MyClassEnumerator : IEnumerator<MyClassItem>
    {
        private MyClassItem[] _items;
        private int _index = -1;

        public MyClassEnumerator(MyClassItem[] items)
        {
            _items = items;
        }

        public MyClassItem Current => _items[_index];

        object IEnumerator.Current => Current;

        public bool MoveNext() => ++_index < _items.Length;

        public void Reset() => _index = -1;

        public void Dispose() { }
    }

}

   

