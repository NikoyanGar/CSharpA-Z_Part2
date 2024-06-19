namespace _004_methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum1 = CalculateSum(2, 3);
            int sum2 = CalculateSum(2, 3, 4);
            int sum3 = CalculateSum(2, 3, 4, 5);
            double sum4 = CalculateSum(2.5, 3.5);
            double sum5 = CalculateSum(2.5, 3.5, 4.5);
            double sum6 = CalculateSum(2.5, 3.5, 4.5, 5.5);

            Console.WriteLine("Sum1: " + sum1);
            Console.WriteLine("Sum2: " + sum2);
            Console.WriteLine("Sum3: " + sum3);
            Console.WriteLine("Sum4: " + sum4);
            Console.WriteLine("Sum5: " + sum5);
            Console.WriteLine("Sum6: " + sum6);
        }

        public static int CalculateSum(int x, int y)
        {
            return x + y;
        }

        public static int CalculateSum(int x, int y, int z)
        {
            return x + y + z;
        }

        // Overloaded methods
        public static int CalculateSum(int x, int y, int z, int w)
        {
            return x + y + z + w;
        }

        public static double CalculateSum(double x, double y)
        {
            return x + y;
        }

        public static double CalculateSum(double x, double y, double z)
        {
            return x + y + z;
        }

        public static double CalculateSum(double x, double y, double z, double w)
        {
            return x + y + z + w;
        }
    }
}
