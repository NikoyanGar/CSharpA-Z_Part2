namespace _008_yield
{
    static class CollectionHelper
    {
        public static IEnumerable<string> CreateEnumerable()
        {
            yield return "Hello";
            yield return "Hello";
            yield return "Hello";
            yield return "Hello";
            yield return "Hello";
        }
    }
}
