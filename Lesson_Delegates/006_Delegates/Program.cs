namespace _006_Delegates
{
    internal class Program
    {
        public delegate int MyAction(int a1, int b1);

        static void Main(string[] args)
        {

            MyAction plus = (a, b) => a + b; // Define a delegate named "plus" that takes two integers and returns their sum
            MyAction minus = (a, b) => a - b; // Define a delegate named "minus" that takes two integers and returns their difference

            int res1 = plus(10, 5) + plus(10, 5); // Call the "plus" delegate twice with arguments 10 and 5, and store the sum in "res1"
            int res2 = minus(10, 5); // Call the "minus" delegate with arguments 10 and 5, and store the difference in "res2"

            #region

            MyAction action;

            // Lambda Method
            action = delegate (int a, int b) // Define a delegate named "action" using a lambda method
            {
                return a + b;
            };
            Console.WriteLine("Lambda Method: 10 + 5 = " + action(10, 5)); // Call the "action" delegate with arguments 10 and 5, and print the result

            // Lambda Operator
            action = (a, b) => // Define a delegate named "action" using a lambda operator
            {
                return a + b;
            };
            Console.WriteLine("Lambda Operator: 10 + 5 = " + action(10, 5)); // Call the "action" delegate with arguments 10 and 5, and print the result

            // Lambda Expression
            action = (a, b) => a + b; // Define a delegate named "action" using a lambda expression that directly returns the sum of the two arguments

            //action = new MyAction(delegate (int a, int b) { return a + b; });
            Console.WriteLine("Lambda Expression: 10 + 5 = " + action(10, 5)); // Call the "action" delegate with arguments 10 and 5, and print the result

            // Difference between "Lambda Operator" and "Lambda Expression"

            #endregion

            Console.ReadLine();
        }
    }
}
