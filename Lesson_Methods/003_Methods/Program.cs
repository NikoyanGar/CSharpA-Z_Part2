namespace _003_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculateSum(1, 2);
            CalculateSumAndReturn(1, 2);
            var sum = CalculateSumAndReturn(1, 2);
            Console.WriteLine(sum);
        }
        public static void CalculateSum(int x, int y)
        {
            int sum = x + y;
        }
        public static int CalculateSumAndReturn(int x, int y)
        {
            return x + y;
        }
    }
}
