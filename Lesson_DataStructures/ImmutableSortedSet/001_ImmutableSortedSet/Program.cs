using System.Collections.Immutable;

namespace _001_ImmutableSortedSet
{
    // Pros of using ImmutableSortedSet<T>:
    // - Maintains elements sorted automatically.
    // - Immutable: any modification returns a new set, original remains unchanged.
    // - Fast lookup: O(log n) for search, O(log n) for add/remove.
    // - Useful for thread-safe, functional programming scenarios.
    // Use Case: Need sorted, unique elements, thread safety, and immutability.
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an empty ImmutableSortedSet (O(1))
            var set = ImmutableSortedSet<int>.Empty;

            // Add elements (O(log n) per add, returns new set)
            set = set.Add(10); // O(log n)
            set = set.Add(3);  // O(log n)
            set = set.Add(1);  // O(log n)
            set = set.Add(2);  // O(log n)

            Console.WriteLine("ImmutableSortedSet contents:");
            // Enumeration is O(n)
            foreach (var item in set)
                Console.WriteLine(item);

            // Check if set contains an element (O(log n))
            Console.WriteLine($"Contains 2 → {set.Contains(2)}"); // O(log n)

            // Remove an element (O(log n), returns new set)
            var updatedSet = set.Remove(1); // O(log n)

            Console.WriteLine("After remove:");
            foreach (var item in updatedSet)
                Console.WriteLine(item);

            // Original set remains unchanged (immutability)
            Console.WriteLine("Original set still contains:");
            foreach (var item in set)
                Console.WriteLine(item);
        }
    }
}
