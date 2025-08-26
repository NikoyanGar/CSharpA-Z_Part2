namespace _001_Events;

//Key points
//event = controlled multicast delegate (only +=/-= allowed from outside).
//?.Invoke avoids NullReferenceException when there are no subscribers.
//Try it
//Add a third handler.
//Unsubscribe one handler (-=) and press again.

class Button
{
    public event EventHandler? Click; // 1) declare

    public void Press()
    {
        Console.WriteLine("Button pressed");
        Click?.Invoke(this, EventArgs.Empty); // 3) raise (safe)
    }
}

class Program
{
    static void Main()
    {
        var btn = new Button();

        // 2) subscribe
        btn.Click += (s, e) => Console.WriteLine("Handler #1: open dialog");
        btn.Click += (s, e) => Console.WriteLine("Handler #2: play sound");

        btn.Press();
    }
}
