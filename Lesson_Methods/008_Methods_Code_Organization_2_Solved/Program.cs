namespace _008_Methods_Code_Organization_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Step 1: Display welcome message
            Console.WriteLine("Welcome to User Registration!");

            // Step 2: Call the UserRegistration method to handle the registration process
            UserRegistration();

            // Step 9: Display success message
            Console.WriteLine("Registration successful!");
        }

        static void UserRegistration()
        {
            // Step 2: Prompt user for username, can be more complex
            string username = GetUserInput("Enter your username:");

            // Step 3: Validate username, can be more complex
            if (!ValidateInput(username, "Username"))
            {
                return;
            }

            // Step 4: Prompt user for password, can be more complex
            string password = GetUserInput("Enter your password:");

            // Step 5: Validate password, can be more complex
            if (!ValidateInput(password, "Password"))
            {
                return;
            }

            // Step 6: Prompt user for email
            string email = GetUserInput("Enter your email:");

            // Step 7: Validate email, can be more complex
            if (!ValidateInput(email, "Email"))
            {
                return;
            }

            // Step 8: Display registration summary
            DisplayRegistrationSummary(username, password, email);
        }

        static string GetUserInput(string prompt)
        {
            Console.Write(prompt + " ");
            return Console.ReadLine();
        }

        static bool ValidateInput(string input, string fieldName)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine($"{fieldName} cannot be empty or whitespace.");
                return false;
            }
            // Additional complex validation logic can be added here
            return true;
        }

        static void DisplayRegistrationSummary(string username, string password, string email)
        {
            Console.WriteLine("Registration Summary:");
            Console.WriteLine($"Username: {username}");
            Console.WriteLine($"Password: {password}");
            Console.WriteLine($"Email: {email}");
        }
    }
}

