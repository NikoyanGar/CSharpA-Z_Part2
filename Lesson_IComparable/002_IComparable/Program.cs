namespace _002_IComparable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Temperature> temperatures = new List<Temperature>();
            // Initialize random number generator.
            Random rnd = new Random();

            // Generate 10 temperatures between 0 and 100 randomly.
            for (int ctr = 1; ctr <= 10; ctr++)
            {
                int degrees = rnd.Next(0, 100);
                Temperature temp = new Temperature();
                temp.Fahrenheit = degrees;
                temperatures.Add(temp);
            }

            Sort(temperatures);

            foreach (Temperature temp in temperatures)
            {

                Console.WriteLine(temp.Fahrenheit);
            }
        }
        public static void Sort(List<Temperature> temperatures)//BubbleSort
        {
            int n = temperatures.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (temperatures[j].Fahrenheit > temperatures[j + 1].Fahrenheit)
                    {
                        // Swap temperatures[j] and temperatures[j + 1]
                        Temperature temp = temperatures[j];
                        temperatures[j] = temperatures[j + 1];
                        temperatures[j + 1] = temp;
                    }
                }
            }
        }
    }
}
