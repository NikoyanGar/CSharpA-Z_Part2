namespace _001_PriorityQueue
{
    // Pros of using PriorityQueue<TElement, TPriority>:
    // - Efficiently retrieves the element with the highest or lowest priority.
    // - Insert and remove operations are O(log n).
    // - Useful for scheduling, pathfinding, and any scenario where priority matters.
    // Use Case: Fast access to highest/lowest priority, dynamic priorities, moderate/large dataset.
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a priority queue where int is the element and priority
            var pq = new PriorityQueue<string, int>();

            // Enqueue items (O(log n) each)
            pq.Enqueue("Low", 3);    // Priority 3
            pq.Enqueue("High", 1);   // Priority 1
            pq.Enqueue("Medium", 2); // Priority 2

            Console.WriteLine("PriorityQueue contents (dequeue order):");
            // Dequeue items (O(log n) each)
            while (pq.Count > 0)
            {
                var item = pq.Dequeue();
                Console.WriteLine(item);
            }

            // Enqueue more items
            pq.Enqueue("Urgent", 0);
            pq.Enqueue("Normal", 5);

            // Peek at the highest priority item (O(1))
            Console.WriteLine($"Peek: {pq.Peek()}");

            // Remove highest priority item (O(log n))
            pq.Dequeue();

            Console.WriteLine("After dequeue:");
            while (pq.Count > 0)
            {
                Console.WriteLine(pq.Dequeue());
            }
        }
    }
}
