namespace _003_Events;

class User
{
    public Guid Id { get; } = Guid.NewGuid();
    public string Name { get; init; } = "";
    public string? Email { get; init; }
    public string? Phone { get; init; }
    public string? ReferralCode { get; init; }
}
