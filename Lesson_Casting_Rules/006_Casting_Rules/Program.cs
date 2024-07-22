namespace _006_Casting_Rules
{
    //User-Defined Conversions
    internal class Program
    {
        static void Main(string[] args)
        {
            Fahrenheit f = new Fahrenheit { Degrees = 100 };
            Celsius c = f; // Implicit conversion
            Console.WriteLine(c.Degrees); // Outputs 37.7778
        }
    }
}
