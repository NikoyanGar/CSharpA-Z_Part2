using BenchmarkDotNet.Running;
using System;

//In.NET, the choice of collection type(class vs struct),
//enumerator type(class vs struct), and item type(reference vs value)
//significantly affects performance and memory usage.

//===================================================
//1. Heap Allocation vs Stack Allocation
//===================================================

//Reference types (`class`) are always allocated on the heap and managed by the garbage collector.
//Value types (`struct`) can be allocated on the stack,
//reducing GC pressure. Struct enumerators allow allocation-free iteration.

//Example: Struct Enumerator vs Class Enumerator

//struct Enumerator (no heap allocation):

namespace _008_IEnumerable_Perf
{
    internal partial class Program
    {
        public static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<EnumeratorBenchmarks>();
        }

    }
    // Recommendation Summary
    //===================================================

    //| Scenario                                | Recommendation                      |
    //|-----------------------------------------|--------------------------------------|
    //| High performance iteration (value type) | struct enumerator, IEnumerable<T>   |
    //| General usage                           | class enumerator, IEnumerable<T>    |
    //| Span-like fast access                   | Span<T>.Enumerator                  |
    //| Avoiding allocations                    | Avoid class + foreach on large loop |
    //| Avoid boxing                            | Don't use non-generic interfaces    |

    //===================================================
    //Conclusion:
    //Efficient use of enumerators is critical in tight loops and GC-sensitive apps. Prefer struct enumerators 
    //and generic interfaces to avoid allocations and improve performance.
}
