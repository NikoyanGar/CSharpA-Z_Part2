namespace _008_Methods_Code_Organization
{
    class Program
    {
        static void Main()
        {
            // Tax calculation
            decimal purchaseAmount = 100.0m;
            decimal salesTaxRate = 8.5m;
            decimal taxAmount = purchaseAmount * (salesTaxRate / 100);
            Console.WriteLine($"Tax amount: ${taxAmount}");

            // Email validation
            string userInput = "user@example.com";
            bool isValidEmail = false;
            if (userInput.Contains("@") && userInput.Contains("."))
            {
                isValidEmail = true;
            }
            if (isValidEmail)
            {
                Console.WriteLine("Valid email address!");
            }
            else
            {
                Console.WriteLine("Invalid email address.");
            }

            // Fetching data from an API
            string apiResponse = "Sample data from API";
            Console.WriteLine($"Fetched data: {apiResponse}");

            // Debugging nightmare
            // ... (lots of unrelated code here)

            // Readability? What readability?
            // ... (more spaghetti code)

            // And let's throw in some magic numbers for good measure
            int magicNumber = 42;
            int result = magicNumber * 2;
            Console.WriteLine($"The answer is {result}!");

            // Don't forget to close your database connections!
            // ... (just kidding, there are no database connections)

            // And finally, a comment that doesn't make sense
            // TODO: Fix everything (but not really)

            // The end (or is it?)
        }
    }

}
