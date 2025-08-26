namespace _003_Events;

static class SmsService
{
    public static void OnUserRegistered(object? s, UserRegisteredEventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(e.User.Phone))
            Console.WriteLine($"[SMS] Hi {e.User.Name}, thanks for joining!");
    }
}
