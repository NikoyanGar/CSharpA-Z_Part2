using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_IEnumerable_Perf
{
    public class EnumeratorBenchmarks
    {
        private MyStructEnumerable _structEnumerable;
        private MyClassEnumerable _classEnumerable;

        [GlobalSetup]
        public void Setup()
        {
            var structItems = new MyStructItem[1000];
            var classItems = new MyClassItem[1000];
            for (int i = 0; i < 1000; i++)
            {
                structItems[i] = new MyStructItem { Value = i };
                classItems[i] = new MyClassItem { Value = i };
            }

            _structEnumerable = new MyStructEnumerable(structItems);
            _classEnumerable = new MyClassEnumerable(classItems);
        }

        [Benchmark]
        public int SumStructItems()
        {
            int sum = 0;
            foreach (var item in _structEnumerable)
                sum += item.Value;
            return sum;
        }

        [Benchmark]
        public int SumClassItems()
        {
            int sum = 0;
            foreach (var item in _classEnumerable)
                sum += item.Value;
            return sum;
        }
    }
}
