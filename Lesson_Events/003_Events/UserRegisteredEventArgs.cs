namespace _003_Events;

class UserRegisteredEventArgs : EventArgs
{
    public User User { get; }
    public DateTime RegisteredAtUtc { get; } = DateTime.UtcNow;
    public UserRegisteredEventArgs(User user) => User = user;
}
