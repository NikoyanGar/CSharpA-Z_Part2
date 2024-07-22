namespace _001_HashSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> set = new HashSet<int>();
            for (int i = 0; i < int.MaxValue; i++)
            {
                set.Add(i);
            }
        }
    }
}
