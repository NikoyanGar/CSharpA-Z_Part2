using System.Collections;

namespace _008_IEnumerable_Perf
{
    public class MyStructEnumerable : IEnumerable<MyStructItem>
    {
        private readonly MyStructItem[] _items;

        public MyStructEnumerable(MyStructItem[] items)
        {
            _items = items;
        }

        public IEnumerator<MyStructItem> GetEnumerator() => new MyStructEnumerator(_items);

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    }
}
