namespace _006_Events_01;

using System;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Threading.Tasks;

public delegate Task AsyncEventHandler<TEventArgs>(object? sender, TEventArgs args);

class AsyncPublisher
{
    public event AsyncEventHandler<EventArgs>? Happened;

    public async Task RaiseAsync()
    {
        var handlers = Happened;
        if (handlers == null) return;

        var tasks = handlers
            .GetInvocationList()
            .Cast<AsyncEventHandler<EventArgs>>()
            .Select(h => h(this, EventArgs.Empty));

        await Task.WhenAll(tasks); // await all subscribers
    }
}

//Key points
//Custom AsyncEventHandler<T> lets the publisher await all handlers.
//Better for workflows that must complete before proceeding.
//Try it
//Add a handler that throws; wrap each call in try/catch and aggregate errors.

class Program
{
    static async Task Main()
    {
        var p = new AsyncPublisher();
        p.Happened += async (s, e) => { await Task.Delay(300); Console.WriteLine("A"); };
        p.Happened += async (s, e) => { await Task.Delay(100); Console.WriteLine("B"); };

        await p.RaiseAsync();
        Console.WriteLine("All handlers completed.");
    }
}

//Quick Cheatsheet(for students)

//Prefer EventHandler / EventHandler<TEventArgs>.

//Raise via protected virtual OnXxx(TEventArgs e) pattern.

//Always null-check with ?.Invoke.

//Unsubscribe(-=) to avoid leaks.

//For async orchestration, consider a custom AsyncEventHandler<T> or use messaging (e.g., queues) instead of plain events.
