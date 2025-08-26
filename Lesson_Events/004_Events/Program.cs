using System.Timers;
//4) Unsubscribe & lifetime(avoid dangling subscriptions)

//Goal: show why -= matters.
namespace _004_Events;

internal class Program
{
    static void Main(string[] args)
    {
        var timer = new System.Timers.Timer(500);//A timer is created to tick every 500 milliseconds.
        //An event handler (handler) is defined using a lambda. It prints the current time each time the timer "ticks".
        ElapsedEventHandler handler = (s, e) => Console.WriteLine("Tick " + DateTime.Now.ToLongTimeString());

        //3.Subscribing to the Event
        //The handler is attached to the timer's Elapsed event:
        timer.Elapsed += handler;//This means every time the timer elapses, your handler runs.
        timer.Start();

        Console.WriteLine("Press Enter to stop subscribing...");
        Console.ReadLine();

        // Important: unsubscribe when you no longer need notifications
        timer.Elapsed -= handler;
        timer.Stop();
        timer.Dispose();

        Console.WriteLine("Unsubscribed. Press Enter to exit.");
        Console.ReadLine();
    }
}
//Key points
//If a long-lived publisher holds your handler, your object can’t be GC’d → potential memory issues.
//Always -= (or use IDisposable patterns) when done.
//Try it
//Move the handler into a small class; create it in a scope; see how unsubscribing lets it be collected.
