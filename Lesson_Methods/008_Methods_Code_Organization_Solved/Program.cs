namespace _008_Methods_Code_Organization_Solved
{
    class Program
    {
        static void Main()
        {
            decimal purchaseAmount = 100.0m;
            decimal salesTaxRate = 8.5m;

            decimal taxAmount = CalculateTax(purchaseAmount, salesTaxRate);
            Console.WriteLine($"Tax amount: ${taxAmount}");

            string userInput = "user@example.com";
            if (IsValidEmail(userInput))
            {
                Console.WriteLine("Valid email address!");
            }
            else
            {
                Console.WriteLine("Invalid email address.");
            }

            string data = FetchDataFromAPI();
            Console.WriteLine($"Fetched data: {data}");

            // Debugging and other code can now be organized separately

            // And finally, a meaningful comment:
            // TODO: Refactor and improve code readability
        }

        static decimal CalculateTax(decimal purchaseAmount, decimal salesTaxRate)
        {
            return purchaseAmount * (salesTaxRate / 100);
        }

        static bool IsValidEmail(string email)
        {
            // Add your email validation logic here
            // For simplicity, let's assume it always returns true
            return true;
        }

        static string FetchDataFromAPI()
        {
            // Simulate fetching data from an API
            return "Sample data from API";
        }
    }

}
