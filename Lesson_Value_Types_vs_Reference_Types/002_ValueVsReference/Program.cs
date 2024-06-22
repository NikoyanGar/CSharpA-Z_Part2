namespace _002_ValueVsReference
{
    //Example 2: Value Type Passed as Method Argument
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 5;
            Console.WriteLine($"Original number: {number}"); // Output: Original number: 5
            ModifyValue(number);
            Console.WriteLine($"Modified number: {number}");
        }
        static void ModifyValue(int value)
        {
            value = value * 2; // Modify the value
        }

        // Output: Modified number: 5
    }
}
