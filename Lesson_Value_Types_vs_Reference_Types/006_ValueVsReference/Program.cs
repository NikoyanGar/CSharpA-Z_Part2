namespace _006_ValueVsReference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = [1, 2, 3, 4, 5];
            Console.WriteLine($"Original array: {string.Join(", ", numbers)}"); // Output: Original array: 1, 2, 3, 4, 5
            ModifyArray(numbers);
            Console.WriteLine($"Modified array: {string.Join(", ", numbers)}");
        }

        static void ModifyArray(int[] array)
        {
            array[0] = 10;
        }
    }
}
