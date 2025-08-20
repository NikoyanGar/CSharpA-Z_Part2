using System.Buffers.Text;
using System.Data;
using System.Runtime.Intrinsics.X86;

namespace _001_SortedList
{
    // Pros of using SortedList<TKey, TValue>:
    // - Maintains elements sorted by key automatically.
    // - Fast lookup by key: O(log n) for search, O(n) for insert/remove.
    // - Access by index is O(1).
    // - Useful when you need both fast key lookup and ordered enumeration.
    // Use Case: Fast lookups, needs index-based access, small/moderate dataset.
    internal class Program
    {
        static void Main(string[] args)
        {
            // O(n) for insertion (since SortedList keeps keys sorted)
            var sortedList = new SortedList<int, string>()
                    {
                        { 10, "ten" } // O(n) insert
                    };

            // Insert items (O(n) each)
            sortedList.Add(3, "Three"); // O(n)
            sortedList.Add(1, "One");   // O(n)
            sortedList.Add(2, "Two");   // O(n)

            Console.WriteLine("SortedList contents:");
            // Enumeration is O(n)
            foreach (var kv in sortedList)
                Console.WriteLine($"{kv.Key} = {kv.Value}");

            // Access by key is O(log n)
            Console.WriteLine($"Key 2 → {sortedList[2]}"); // O(log n)

            // Access by index is O(1)
            Console.WriteLine($"Index 0 → {sortedList.Values[0]}"); // O(1)

            // Update by key is O(log n)
            sortedList[2] = "Two updated"; // O(log n)

            // Remove by key is O(n)
            sortedList.Remove(1); // O(n)

            Console.WriteLine("After update & remove:");
            // Enumeration is O(n)
            foreach (var kv in sortedList)
                Console.WriteLine($"{kv.Key} = {kv.Value}");
        }
    }
}
