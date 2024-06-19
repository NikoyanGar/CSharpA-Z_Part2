namespace _005_methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intNumbers = { 1, 2, 3, 4, 5 };
            double[] doubleNumbers = { 1.5, 2.5, 3.5, 4.5, 5.5 };

            int intSum = CalculateSum(intNumbers);
            double doubleSum = CalculateSum(doubleNumbers);

            Console.WriteLine("Sum of integers: " + intSum);
            Console.WriteLine("Sum of doubles: " + doubleSum);
        }

        public static int CalculateSum(int[] numbers)
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            return sum;
        }

        public static double CalculateSum(double[] numbers)
        {
            double sum = 0;
            foreach (double num in numbers)
            {
                sum += num;
            }
            return sum;
        }
    }
}
