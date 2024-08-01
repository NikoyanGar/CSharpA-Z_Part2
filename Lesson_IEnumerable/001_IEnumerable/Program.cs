using System.Collections;

namespace _001_IEnumerable
{
    //IEnumerable: This is an interface that provides a method to retrieve an enumerator for a collection.Any class that implements IEnumerable can be used with a foreach loop.
    //IEnumerator: This interface provides methods to iterate over a collection, allowing forward-only cursor movement through the collection
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int> { 1, 2, 3 };

            IEnumerator<int> enumerator = numbers.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }

            //SimpleCollection ints = new SimpleCollection();
            //IEnumerator<int> enumerator1 = ints.GetEnumerator();
            //while (enumerator1.MoveNext())
            //{
            //    Console.WriteLine(enumerator.Current);
            //}
            //or
            //foreach (int i in ints)
            //{
            //    Console.WriteLine(i);
            //}
        }
    }
    public class SimpleCollection : IEnumerable<int>
    {
        private int[] data = { 1, 2, 3 };
        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < data.Length; i++)
            {
                yield return data[i];
            }
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
