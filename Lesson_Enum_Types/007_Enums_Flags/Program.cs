namespace _007_Enums_Flags
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CoffeeOptions myCoffee = CoffeeOptions.Sugar | CoffeeOptions.Cream;

            Console.WriteLine(myCoffee); // Output: Sugar, Cream

            // Checking if a flag is set
            bool hasSugar = myCoffee.HasFlag(CoffeeOptions.Sugar);
            Console.WriteLine($"Contains sugar: {hasSugar}"); // Output: Contains sugar: True
        }
    }

    [Flags]
    enum CoffeeOptions
    {
        None = 0,
        Sugar = 1,//<<1
        Milk = 2,//1<<2
        Cream = 4,//1<<3
        Chocolate = 8//1<<4
    }
}
