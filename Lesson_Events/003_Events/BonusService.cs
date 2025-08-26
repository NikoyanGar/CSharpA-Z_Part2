namespace _003_Events;

static class BonusService
{
    public static void OnUserRegistered(object? s, UserRegisteredEventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(e.User.ReferralCode))
            Console.WriteLine($"[Bonus] Referral {e.User.ReferralCode}: +100 points");
    }
}
