using System;
using System.Collections;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
namespace _008_IEnumerable_Perf_all_combinations_not_gen
{
    #region Item Types
    public struct MyStructItem
    {
        public int Value;
    }

    public class MyClassItem
    {
        public int Value;
    }
    #endregion

    #region Enumerators
    public struct StructEnumerator_StructItem : IEnumerator
    {
        private readonly MyStructItem[] _items;
        private int _index;

        public StructEnumerator_StructItem(MyStructItem[] items)
        {
            _items = items;
            _index = -1;
        }

        public object Current => _items[_index];
        public bool MoveNext() => ++_index < _items.Length;
        public void Reset() => _index = -1;
        public void Dispose() { }
    }

    public struct StructEnumerator_ClassItem : IEnumerator
    {
        private readonly MyClassItem[] _items;
        private int _index;

        public StructEnumerator_ClassItem(MyClassItem[] items)
        {
            _items = items;
            _index = -1;
        }

        public object Current => _items[_index];
        public bool MoveNext() => ++_index < _items.Length;
        public void Reset() => _index = -1;
        public void Dispose() { }
    }

    public class ClassEnumerator_StructItem : IEnumerator
    {
        private readonly MyStructItem[] _items;
        private int _index;

        public ClassEnumerator_StructItem(MyStructItem[] items)
        {
            _items = items;
            _index = -1;
        }

        public object Current => _items[_index];
        public bool MoveNext() => ++_index < _items.Length;
        public void Reset() => _index = -1;
        public void Dispose() { }
    }

    public class ClassEnumerator_ClassItem : IEnumerator
    {
        private readonly MyClassItem[] _items;
        private int _index;

        public ClassEnumerator_ClassItem(MyClassItem[] items)
        {
            _items = items;
            _index = -1;
        }

        public object Current => _items[_index];
        public bool MoveNext() => ++_index < _items.Length;
        public void Reset() => _index = -1;
        public void Dispose() { }
    }
    #endregion

    #region Enumerables
    public struct StructEnumerable_StructItem_StructEnumerator : IEnumerable
    {
        private readonly MyStructItem[] _items;
        public StructEnumerable_StructItem_StructEnumerator(MyStructItem[] items) => _items = items;
        public IEnumerator GetEnumerator() => new StructEnumerator_StructItem(_items);
    }

    public struct StructEnumerable_ClassItem_StructEnumerator : IEnumerable
    {
        private readonly MyClassItem[] _items;
        public StructEnumerable_ClassItem_StructEnumerator(MyClassItem[] items) => _items = items;
        public IEnumerator GetEnumerator() => new StructEnumerator_ClassItem(_items);
    }

    public struct StructEnumerable_StructItem_ClassEnumerator : IEnumerable
    {
        private readonly MyStructItem[] _items;
        public StructEnumerable_StructItem_ClassEnumerator(MyStructItem[] items) => _items = items;
        public IEnumerator GetEnumerator() => new ClassEnumerator_StructItem(_items);
    }

    public struct StructEnumerable_ClassItem_ClassEnumerator : IEnumerable
    {
        private readonly MyClassItem[] _items;
        public StructEnumerable_ClassItem_ClassEnumerator(MyClassItem[] items) => _items = items;
        public IEnumerator GetEnumerator() => new ClassEnumerator_ClassItem(_items);
    }

    public class ClassEnumerable_StructItem_StructEnumerator : IEnumerable
    {
        private readonly MyStructItem[] _items;
        public ClassEnumerable_StructItem_StructEnumerator(MyStructItem[] items) => _items = items;
        public IEnumerator GetEnumerator() => new StructEnumerator_StructItem(_items);
    }

    public class ClassEnumerable_ClassItem_StructEnumerator : IEnumerable
    {
        private readonly MyClassItem[] _items;
        public ClassEnumerable_ClassItem_StructEnumerator(MyClassItem[] items) => _items = items;
        public IEnumerator GetEnumerator() => new StructEnumerator_ClassItem(_items);
    }

    public class ClassEnumerable_StructItem_ClassEnumerator : IEnumerable
    {
        private readonly MyStructItem[] _items;
        public ClassEnumerable_StructItem_ClassEnumerator(MyStructItem[] items) => _items = items;
        public IEnumerator GetEnumerator() => new ClassEnumerator_StructItem(_items);
    }

    public class ClassEnumerable_ClassItem_ClassEnumerator : IEnumerable
    {
        private readonly MyClassItem[] _items;
        public ClassEnumerable_ClassItem_ClassEnumerator(MyClassItem[] items) => _items = items;
        public IEnumerator GetEnumerator() => new ClassEnumerator_ClassItem(_items);
    }
    #endregion

    [MemoryDiagnoser]
    [IterationCount(10)]
    public class EnumeratorAllCombinationsBenchmark
    {
        private MyStructItem[] _structItems;
        private MyClassItem[] _classItems;

        private StructEnumerable_StructItem_StructEnumerator _structEnum_structItem_structEnumr;
        private StructEnumerable_ClassItem_StructEnumerator _structEnum_classItem_structEnumr;
        private StructEnumerable_StructItem_ClassEnumerator _structEnum_structItem_classEnumr;
        private StructEnumerable_ClassItem_ClassEnumerator _structEnum_classItem_classEnumr;
        private ClassEnumerable_StructItem_StructEnumerator _classEnum_structItem_structEnumr;
        private ClassEnumerable_ClassItem_StructEnumerator _classEnum_classItem_structEnumr;
        private ClassEnumerable_StructItem_ClassEnumerator _classEnum_structItem_classEnumr;
        private ClassEnumerable_ClassItem_ClassEnumerator _classEnum_classItem_classEnumr;

        [GlobalSetup]
        public void Setup()
        {
            const int size = 10000;
            _structItems = new MyStructItem[size];
            _classItems = new MyClassItem[size];

            for (int i = 0; i < size; i++)
            {
                _structItems[i] = new MyStructItem { Value = i };
                _classItems[i] = new MyClassItem { Value = i };
            }

            _structEnum_structItem_structEnumr = new StructEnumerable_StructItem_StructEnumerator(_structItems);
            _structEnum_classItem_structEnumr = new StructEnumerable_ClassItem_StructEnumerator(_classItems);
            _structEnum_structItem_classEnumr = new StructEnumerable_StructItem_ClassEnumerator(_structItems);
            _structEnum_classItem_classEnumr = new StructEnumerable_ClassItem_ClassEnumerator(_classItems);
            _classEnum_structItem_structEnumr = new ClassEnumerable_StructItem_StructEnumerator(_structItems);
            _classEnum_classItem_structEnumr = new ClassEnumerable_ClassItem_StructEnumerator(_classItems);
            _classEnum_structItem_classEnumr = new ClassEnumerable_StructItem_ClassEnumerator(_structItems);
            _classEnum_classItem_classEnumr = new ClassEnumerable_ClassItem_ClassEnumerator(_classItems);
        }

        [Benchmark]
        public double StructEnum_StructItem_StructEnumerator()
        {
            double sum = 0;
            foreach (var item in _structEnum_structItem_structEnumr)
                sum += Math.Sqrt(((MyStructItem)item).Value);
            return sum;
        }

        [Benchmark]
        public double StructEnum_ClassItem_StructEnumerator()
        {
            double sum = 0;
            foreach (var item in _structEnum_classItem_structEnumr)
                sum += Math.Sqrt(((MyClassItem)item).Value);
            return sum;
        }

        [Benchmark]
        public double StructEnum_StructItem_ClassEnumerator()
        {
            double sum = 0;
            foreach (var item in _structEnum_structItem_classEnumr)
                sum += Math.Sqrt(((MyStructItem)item).Value);
            return sum;
        }

        [Benchmark]
        public double StructEnum_ClassItem_ClassEnumerator()
        {
            double sum = 0;
            foreach (var item in _structEnum_classItem_classEnumr)
                sum += Math.Sqrt(((MyClassItem)item).Value);
            return sum;
        }

        [Benchmark]
        public double ClassEnum_StructItem_StructEnumerator()
        {
            double sum = 0;
            foreach (var item in _classEnum_structItem_structEnumr)
                sum += Math.Sqrt(((MyStructItem)item).Value);
            return sum;
        }

        [Benchmark]
        public double ClassEnum_ClassItem_StructEnumerator()
        {
            double sum = 0;
            foreach (var item in _classEnum_classItem_structEnumr)
                sum += Math.Sqrt(((MyClassItem)item).Value);
            return sum;
        }

        [Benchmark]
        public double ClassEnum_StructItem_ClassEnumerator()
        {
            double sum = 0;
            foreach (var item in _classEnum_structItem_classEnumr)
                sum += Math.Sqrt(((MyStructItem)item).Value);
            return sum;
        }

        [Benchmark]
        public double ClassEnum_ClassItem_ClassEnumerator()
        {
            double sum = 0;
            foreach (var item in _classEnum_classItem_classEnumr)
                sum += Math.Sqrt(((MyClassItem)item).Value);
            return sum;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            BenchmarkRunner.Run<EnumeratorAllCombinationsBenchmark>();
        }
    }
}

