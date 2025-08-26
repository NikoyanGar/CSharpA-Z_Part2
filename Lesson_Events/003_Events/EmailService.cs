namespace _003_Events;

static class EmailService
{
    public static void OnUserRegistered(object? s, UserRegisteredEventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(e.User.Email))
            Console.WriteLine($"[Email] Welcome sent to {e.User.Email}");
    }
}
