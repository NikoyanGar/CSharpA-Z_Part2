namespace _008_yield
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (string item in CollectionHelper.CreateEnumerable())
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
