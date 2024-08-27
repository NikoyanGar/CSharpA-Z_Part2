namespace _005_Delegates
{
    //The purpose of this example is to showcase how delegates can be used to encapsulate and invoke methods dynamically.
    //By using delegates, you can pass methods as parameters, store them in variables, and invoke them at a later time.
    //This provides flexibility and extensibility in your code, allowing you to write more modular and reusable code.
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 10;

            // Defining a delegate named GetSum that can take in an array of integers as parameters and return an integer
            GetSum getSum = delegate (int[] values)
            {
                // Iterating over each value in the array and adding it to the sum variable
                foreach (int value in values)
                {
                    sum += value;
                }
                return sum;
            };

            // Invoking the delegate by passing in the values 10, 20, and 30
            Console.WriteLine("Sum = " + getSum(10, 20, 30));

            // Invoking the delegate again by passing in the values 5 and 1
            Console.WriteLine("Sum = " + getSum(5, 1));

            Console.ReadLine();
        }

        // A method that calculates the sum of an array of integers
        public static int Sum1(params int[] values)
        {
            int sum = 0;
            foreach (int value in values)
            {
                sum += value;
            }
            return sum;
        }

        // Declaration of the delegate named GetSum
        public delegate int GetSum(params int[] values);
    }
}
