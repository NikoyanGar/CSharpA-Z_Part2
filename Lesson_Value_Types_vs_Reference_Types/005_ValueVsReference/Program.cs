namespace _005_ValueVsReference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = [1, 2, 3, 4, 5];
            Console.WriteLine($"Original array: {string.Join(", ", numbers)}"); // Output: Original array: 1, 2, 3, 4, 5
            int[] numbers1 = numbers;
            numbers1[0] = 10;

            Console.WriteLine($"Modified array: {string.Join(", ", numbers1)}");

            Console.WriteLine($"Original array: {string.Join(", ", numbers)}");
        }
    }
}
