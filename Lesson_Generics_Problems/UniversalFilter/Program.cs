namespace UniversalFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Problem: Filter a list of integers to get only even numbers
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
            var evenNumbers = Filter(numbers, n => n % 2 == 0);
            Console.WriteLine("Even numbers: " + string.Join(", ", evenNumbers));

            // Problem: Filter a list of strings to get those with length > 3
            var words = new List<string> { "cat", "house", "dog", "elephant" };
            var longWords = Filter(words, w => w.Length > 3);
            Console.WriteLine("Long words: " + string.Join(", ", longWords));
        }
        // Custom filter: Filter odd numbers from a list of integers
        public static IEnumerable<int> FilterOddNumbers(IEnumerable<int> numbers)
        {
            foreach (var n in numbers)
            {
                if (n % 2 != 0)
                    yield return n;
            }
        }

        // Custom filter: Filter even numbers from a list of integers
        public static IEnumerable<int> FilterEvenNumbers(IEnumerable<int> numbers)
        {
            foreach (var n in numbers)
            {
                if (n % 2 == 0)
                    yield return n;
            }
        }

        // Custom filter: Filter adults (age >= 18) from a list of Human
        public static IEnumerable<Human> FilterAdults(IEnumerable<Human> humans)
        {
            foreach (var h in humans)
            {
                if (h.Age >= 18)
                    yield return h;
            }
        }

        #region solutions
        // Original Filter method
        public static IEnumerable<T> Filter<T>(IEnumerable<T> items, Func<T, bool> predicate)
        {
            foreach (var item in items)
            {
                if (predicate(item))
                    yield return item;
            }
        }

        // Alternative 1: Using LINQ Where
        public static IEnumerable<T> FilterWithLinq<T>(IEnumerable<T> items, Func<T, bool> predicate)
        {
            return items.Where(predicate);
        }

        // Alternative 2: Using a for loop (for IList<T>)
        public static IEnumerable<T> FilterWithForLoop<T>(IList<T> items, Func<T, bool> predicate)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (predicate(items[i]))
                    yield return items[i];
            }
        }

        // Alternative 3: Using recursion
        public static IEnumerable<T> FilterWithRecursion<T>(IEnumerable<T> items, Func<T, bool> predicate)
        {
            return FilterRecursive(items.GetEnumerator(), predicate);
        }

        private static IEnumerable<T> FilterRecursive<T>(IEnumerator<T> enumerator, Func<T, bool> predicate)
        {
            if (!enumerator.MoveNext())
                yield break;

            if (predicate(enumerator.Current))
                yield return enumerator.Current;

            foreach (var item in FilterRecursive(enumerator, predicate))
                yield return item;
        }
        #endregion

    }

    // Example Human class
    public class Human
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

}
