using System.Collections;

namespace _008_IEnumerable_Perf
{
    public class MyClassEnumerable : IEnumerable<MyClassItem>
    {
        private readonly MyClassItem[] _items;

        public MyClassEnumerable(MyClassItem[] items)
        {
            _items = items;
        }

        public IEnumerator<MyClassItem> GetEnumerator() => new MyClassEnumerator(_items);

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
