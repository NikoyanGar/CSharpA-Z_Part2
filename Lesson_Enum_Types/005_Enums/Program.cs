namespace _005_Enums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.DarkBlue;

            Console.WriteLine("This is a colored console output!");

            Console.ResetColor();

            Console.WriteLine(string.Compare("ABC", "abv", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine(string.Compare("ABC", "abv", StringComparison.CurrentCulture));
        }
    }
}
