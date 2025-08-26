namespace _003_Events;

class UserService
{
    public event EventHandler<UserRegisteredEventArgs>? UserRegistered;

    public void Register(User user)
    {
        Console.WriteLine($"Registered: {user.Name}");
        UserRegistered?.Invoke(this, new UserRegisteredEventArgs(user));
    }
}
