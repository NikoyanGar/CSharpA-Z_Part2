namespace _007_Casting_Rules
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Temperature temp = 36.6; // Implicit conversion from double to Temperature
            double degrees = (double)temp; // Explicit conversion from Temperature to double

            Console.WriteLine($"Temperature: {temp.DegreesCelsius}°C");
            Console.WriteLine($"Degrees: {degrees}°C");
        }
    }
    public class Temperature
    {
        public double DegreesCelsius { get; set; }

        public static implicit operator Temperature(double degreesCelsius)
        {
            return new Temperature { DegreesCelsius = degreesCelsius };
        }

        public static explicit operator double(Temperature temp)
        {
            return temp.DegreesCelsius;
        }
    }
}
