namespace _003_Events;

static class CrmService
{
    public static void OnUserRegistered(object? s, UserRegisteredEventArgs e)
    {
        Console.WriteLine($"[CRM] Created card for {e.User.Name} ({e.User.Id})");
    }
}
