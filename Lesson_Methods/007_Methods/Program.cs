namespace _007_Methods
{
    //The params keyword simplifies the syntax when calling methods that accept a variable number of arguments.
    //It allows you to pass in multiple arguments directly without explicitly creating an array. This can make your code more concise and readable,
    //especially when dealing with methods that can accept different numbers of arguments.
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // Example method with parameters
            int result = AddNumbers(5, 10);
            Console.WriteLine("The sum is: " + result);

            int[] numbers = { 1, 2, 3, 4, 5 };
            int sum = AddNumbers(numbers);
            Console.WriteLine("The sum is: " + sum);
            // Example method with params
            //int sum = AddNumbers(1, 2, 3, 4, 5);
            //Console.WriteLine("The sum is: " + sum);
        }

        static int AddNumbers(int num1, int num2)
        {
            return num1 + num2;
        }
        static int AddNumbers(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }
        static int AddNumbers(int[] ints)//For the AddNumbers(int[] ints) method, you need to pass an array of integers explicitly. For example:
        {
            int sum = 0;
            foreach (int num in ints)
            {
                sum += num;
            }
            return sum;
        }
        //static int AddNumbers(params int[] ints)
        //{
        //    int sum = 0;
        //    foreach (int num in ints)
        //    {
        //        sum += num;
        //    }
        //    return sum;
        //}
    }
}
