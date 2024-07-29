namespace _001_IComparable
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

            foreach (Temperature temp in temperatures)
                Console.WriteLine(temp.Fahrenheit);
            //Task to sort the temperatures
        }
    }
}
