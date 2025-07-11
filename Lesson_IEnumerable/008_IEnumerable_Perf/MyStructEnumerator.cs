using System.Collections;

namespace _008_IEnumerable_Perf
{
    // Enumerator for struct item (zero allocation if used generically)
    public struct MyStructEnumerator : IEnumerator<MyStructItem>
    {
        private MyStructItem[] _items;
        private int _index;

        public MyStructEnumerator(MyStructItem[] items)
        {
            _items = items;
            _index = -1;
        }

        public MyStructItem Current => _items[_index];

        object IEnumerator.Current => Current;

        public bool MoveNext() => ++_index < _items.Length;

        public void Reset() => _index = -1;

        public void Dispose() { }
    }

}

