namespace _001_SortedSet
{
    // Pros of using SortedSet<T>:
    // - Maintains elements sorted automatically.
    // - No duplicate elements allowed.
    // - Fast lookup, add, and remove: O(log n) for each.
    // - Useful for set operations (union, intersection, etc.) and ordered enumeration.
    // Use Case: Need sorted, unique collection with fast set operations.
    // Use Case: Unique sorted values, mathematical set operations.
    internal class Program
    {
        static void Main(string[] args)
        {
            // O(log n) for insertion (keeps elements sorted, no duplicates)
            var sortedSet = new SortedSet<int>
                {
                    10, // O(log n) insert
                };

            // Insert items (O(log n) each)
            sortedSet.Add(3); // O(log n)
            sortedSet.Add(1); // O(log n)
            sortedSet.Add(2); // O(log n)
            sortedSet.Add(2); // Duplicate, will not be added

            Console.WriteLine("SortedSet contents:");
            // Enumeration is O(n)
            foreach (var item in sortedSet)
                Console.WriteLine(item);

            // Check existence (O(log n))
            Console.WriteLine($"Contains 2? {sortedSet.Contains(2)}"); // O(log n)

            // Remove item (O(log n))
            sortedSet.Remove(1); // O(log n)

            Console.WriteLine("After remove:");
            foreach (var item in sortedSet)
                Console.WriteLine(item);

            // Set operations
            var otherSet = new SortedSet<int> { 2, 3, 4 };
            sortedSet.UnionWith(otherSet); // O(n)
            Console.WriteLine("After union with {2,3,4}:");
            foreach (var item in sortedSet)
                Console.WriteLine(item);
        }
    }
}
