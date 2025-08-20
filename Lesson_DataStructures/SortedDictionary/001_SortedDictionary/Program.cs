namespace _001_SortedDictionary
{
    // Pros of using SortedDictionary<TKey, TValue>:
    // - Maintains elements sorted by key automatically.
    // - Fast lookup by key: O(log n) for search, insert, and remove.
    // - Enumeration is ordered by key.
    // - Useful when you need fast key lookup and ordered enumeration, but don't need index-based access.
    // Use Case: Large datasets, many inserts/removes.
    internal class Program
    {
        static void Main(string[] args)
        {
            // O(log n) for insertion (SortedDictionary keeps keys sorted)
            var sortedDict = new SortedDictionary<int, string>()
                {
                    { 10, "Ten" } // O(log n) insert
                };

            // Insert items (O(log n) each)
            sortedDict.Add(3, "Three"); // O(log n)
            sortedDict.Add(1, "One");   // O(log n)
            sortedDict.Add(2, "Two");   // O(log n)

            Console.WriteLine("SortedDictionary contents:");
            // Enumeration is O(n)
            foreach (var kv in sortedDict)
                Console.WriteLine($"{kv.Key} = {kv.Value}");

            // Access by key is O(log n)
            Console.WriteLine($"Key 2 → {sortedDict[2]}"); // O(log n)

            // Update by key is O(log n)
            sortedDict[2] = "Two updated"; // O(log n)

            // Remove by key is O(log n)
            sortedDict.Remove(1); // O(log n)

            Console.WriteLine("After update & remove:");
            // Enumeration is O(n)
            foreach (var kv in sortedDict)
                Console.WriteLine($"{kv.Key} = {kv.Value}");
        }
    }
}
