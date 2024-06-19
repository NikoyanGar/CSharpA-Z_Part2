namespace _008_Methods_Code_Organization_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Step 1: Display welcome message
            Console.WriteLine("Welcome to User Registration!");

            // Step 2: Prompt user for username, can be more complex
            Console.Write("Enter your username: ");
            string username = Console.ReadLine();

            // Step 3: Validate username, can be more complex
            if (string.IsNullOrWhiteSpace(username))
            {
                Console.WriteLine("Username cannot be empty or whitespace.");
                return;
            }

            // Step 4: Prompt user for password, can be more complex
            Console.Write("Enter your password: ");
            string password = Console.ReadLine();

            // Step 5: Validate password,, can be more complex
            if (string.IsNullOrWhiteSpace(password))
            {
                Console.WriteLine("Password cannot be empty or whitespace.");
                return;
            }

            // Step 6: Prompt user for email
            Console.Write("Enter your email: ");
            string email = Console.ReadLine();

            // Step 7: Validate email , can be more complex
            if (string.IsNullOrWhiteSpace(email))
            {
                Console.WriteLine("Email cannot be empty or whitespace.");
                return;
            }

            // Step 8: Display registration summary
            Console.WriteLine("Registration Summary:");
            Console.WriteLine($"Username: {username}");
            Console.WriteLine($"Password: {password}");
            Console.WriteLine($"Email: {email}");

            // Step 9: Display success message
            Console.WriteLine("Registration successful!");
        }
    }
}
